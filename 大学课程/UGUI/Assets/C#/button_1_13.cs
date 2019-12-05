using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_1_13: MonoBehaviour {
    public Image image_sp;
    public Sprite[] image_spSPRITE;
    private string lift_OR_right;
    private int i=7;

    //public  string OnClickGameObjectName;
	// Use this for initialization
	void Start () {
        i = Random.Range(0, image_spSPRITE.Length);
	}
	
	// Update is called once per frame
	void Update () {
        image_sp.sprite = image_spSPRITE[i];
        //OnClickGameObjectName = EventSystem.current.currentSelectedGameObject.name;

        //print(OnClickGameObjectName);

	}
    public void OnClickLiftButton() 
    {
        if (i > 0) 
        {
            i--;
        }
        else if (i == 0) 
        {
            i = image_spSPRITE.Length-1;
        }
         
    
    }
    public void OnClickRightButton()
    {
        if (i < image_spSPRITE.Length-1)
        {
           i++;
        }
        else if (i == image_spSPRITE.Length-1)
        {
            i =0;
        }

    }

}
