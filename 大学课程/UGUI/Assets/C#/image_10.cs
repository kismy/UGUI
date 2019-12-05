using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class image_10 : MonoBehaviour {

    public Text text_sp;
    public Text text_btn;
    public Image image_sp;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
       
	}

   public void onClickBtn()
    {
        if (text_btn.text == "打开图片")
        {
            image_sp.gameObject.SetActive(true);
            text_btn.text = "关闭图片";
            text_sp.text = "吉林省四平-东方马德里";


        }
        else
        {
            image_sp.gameObject.SetActive(false);
            text_btn.text = "打开图片";
            text_sp.text = "东方马德里";
        
        
        }
    
    
    
    }

}
