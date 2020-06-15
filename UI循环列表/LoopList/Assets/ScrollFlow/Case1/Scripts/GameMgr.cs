
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour {
    public static GameMgr Instance;
    ItemMessages itemMessages;
    public int firstIndex = 0;
    public int lastIndex = 3;
    public int changeIndex = 0;
    public bool canMove = true;
    public bool canPre = false;
    public bool canNext = false;
    ItemCtrl[] itemCtrls;
    // Use this for initialization
    private void Awake()
    {
        //Cursor.visible = false;//隐藏鼠标
        Instance = this;
       // ReadContentJson();
    }
    void Start () {
        itemCtrls = transform.GetComponentsInChildren<ItemCtrl>();//遍历子物体 放到数组中
        AutoMoveLeft();
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || canPre) && canMove)
        {
            canPre = false;
            MoveLeft();
            AutoMoveLeft();
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || canNext) && canMove)
        {
            canNext = false;
            MoveRight();
            AutoMoveLeft();
        }
    }

    private void AutoMoveLeft()
    {
        CancelInvoke("MoveLeft");
        InvokeRepeating("MoveLeft", 180f, 5f);
    }
    private void MoveLeft()
    {
        foreach (ItemCtrl item in itemCtrls)
        {
            item.ItemMovePre();
        }
        GetCurrentPreIndex();
        canMove = false;
    }
    private void MoveRight()
    {
        foreach (ItemCtrl item in itemCtrls)
        {
            item.ItemMoveNext();
        }
        GetCurrentNextIndex();
        canMove = false;
    }
    public void GetCurrentNextIndex()
    {
        firstIndex--;
        if (firstIndex < 0)
            firstIndex = 3 - 1;
        lastIndex = firstIndex + 3;
        if (lastIndex >= 3)
        {
            lastIndex = 1 - (3 - firstIndex);
        }
    }
    public void GetCurrentPreIndex()
    {
        firstIndex++;
        if (firstIndex == 3)
        {
            firstIndex = 0;
        }
        lastIndex = firstIndex + 1;
        if (lastIndex >= 3)
        {
            lastIndex = 1 - (3 - firstIndex);
        }
    }

}
