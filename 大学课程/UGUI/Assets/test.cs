using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)&& EventSystem.current.currentSelectedGameObject!=null)
        {
            print(EventSystem.current.currentSelectedGameObject.name);
        }
	}
}
