using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BG_change : MonoBehaviour {
    private GameObject root;
    public  GameObject oldobj ;
    private GameObject newobj = null;

	// Use this for initialization
	void Start () {
        root = GameObject.Find("BG");
        
	}

    public void print_name()
    {
        string str = EventSystem.current.currentSelectedGameObject.name;
        switch (str)
        {
            case "Toggle_01":
                newobj = root.transform.Find("BJ_01").gameObject;
                newobj.SetActive(true);                
                oldobj.SetActive(false );
                //为下一次点击toggle切换图片做准备
                oldobj = newobj;
                oldobj.SetActive(true );
                break;

            case "Toggle_02":
                newobj = root.transform.Find("BJ_02").gameObject;
                newobj.SetActive(true);
                oldobj.SetActive(false);
                //为下一次点击toggle切换图片做准备
                oldobj = newobj;
                oldobj.SetActive(true);
                break;


            case "Toggle_03":
                newobj = root.transform.Find("BJ_03").gameObject;
                newobj.SetActive(true);
                oldobj.SetActive(false);
                //为下一次点击toggle切换图片做准备
                oldobj = newobj;
                oldobj.SetActive(true);
                break;

            case "Toggle_04":
                newobj = root.transform.Find("BJ_04").gameObject;
                newobj.SetActive(true);
                oldobj.SetActive(false);
                //为下一次点击toggle切换图片做准备
                oldobj = newobj;
                oldobj.SetActive(true);
                break;

            case "Toggle_05":
                newobj = root.transform.Find("BJ_05").gameObject;
                newobj.SetActive(true);
                oldobj.SetActive(false);
                //为下一次点击toggle切换图片做准备
                oldobj = newobj;
                oldobj.SetActive(true);
                break;

            case "Toggle_06":
                newobj = root.transform.Find("BJ_06").gameObject;
                newobj.SetActive(true);
                oldobj.SetActive(false);
                //为下一次点击toggle切换图片做准备
                oldobj = newobj;
                oldobj.SetActive(true);
                break;
        
        
        
        }
    
    
    
    
    
    }
}
