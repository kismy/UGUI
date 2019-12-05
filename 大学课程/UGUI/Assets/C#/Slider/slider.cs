using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slider : MonoBehaviour {

    public Text mytext;
    public Slider xuetiao;


   
    public void zx()
    {
       
        xuetiao.value = xuetiao.value + 60;
        mytext.text ="血量："+ xuetiao.value.ToString();
    }
    public void jx()
    {
        xuetiao.value = xuetiao.value - 60;
        mytext.text = "血量："+ xuetiao.value.ToString();
    }



}
