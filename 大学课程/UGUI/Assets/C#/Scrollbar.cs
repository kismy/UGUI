using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scrollbar : MonoBehaviour {


    public void image_move(float v)//此处的V是取值范围是【0,1】
    {
        float myvalue = -436f + v * 872f;
        GetComponent<RectTransform>().localPosition = new Vector2(myvalue ,transform.position.y);
    }

    public void image_Scale(float v)//此处的V是取值范围是【0,1】
    {
        float myvalue = 1f + v * 3.0f;
        GetComponent<RectTransform>().localScale = new Vector2(myvalue,myvalue );
    }



	
}
