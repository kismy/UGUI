using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class toggle2 : MonoBehaviour {


    public Text text_chufaEnvent;
    public void chufaEnvent(bool is_On)
    {
        if (is_On)
        {
            text_chufaEnvent.text = "你选择了toggle";
        }
        else
        {
            text_chufaEnvent.text = "你取消选择了toggle";
        }
    
    
    }
}
