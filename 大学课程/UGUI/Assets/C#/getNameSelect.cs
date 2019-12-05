using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class getNameSelect : MonoBehaviour {
    private string getName;
	
	void Update () {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject != null)
        {
            print("Selectable:"+EventSystem.current.currentSelectedGameObject.name);
        }

        GetSelctedGo();
    }

    void GetSelctedGo()
    {
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast( ray,out hitInfo))
        {
            
            print("Ray:"+hitInfo.transform.name);
        }

    }

}
