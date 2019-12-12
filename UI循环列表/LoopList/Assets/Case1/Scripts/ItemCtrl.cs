using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ItemCtrl : MonoBehaviour {
    public Transform prev;
    public Transform next;
    public AnimationCurve alpha;
    CanvasGroup canvasGroup;

    RawImage rw;
    Text title;
    Text message;
    public int startIndex = 0;
    // Use this for initialization
    void Start () {
        canvasGroup = GetComponent<CanvasGroup>();
    }
	
	// Update is called once per frame
	void Update () {
        canvasGroup.alpha = alpha.Evaluate(transform.position.z);
    }
    /// <summary>
    /// 控制移动
    /// </summary>
    public void ItemMovePre()
    {
        int index = int.Parse(transform.name);
        index--;
        if (index < 0)
        {
            index = 2;
        }
        transform.name = index.ToString();
        transform.DOMove(prev.transform.position, 0.5f);
        transform.DOScale(prev.transform.localScale, 0.5f).OnComplete(() =>
        {
            GameMgr.Instance.canMove = true;
        });
    }
    public void ItemMoveNext()
    {
        int index = int.Parse(transform.name);
        index++;
        if (index > 2)
        {
            index = 0;
        }
        transform.name = index.ToString();
        transform.DOMove(next.transform.position, 0.5f);
        transform.DOScale(next.transform.localScale, 0.5f).OnComplete(() =>
        {
            GameMgr.Instance.canMove = true;
        });
    }
}
