using UnityEngine;
using System.Collections;

public class BJ_Move : MonoBehaviour {
    private float x=0.15f ;
    private float y =0.15f;
    public GameObject mainCamera;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        move();
      
	}

    void move()
    {

        mainCamera.transform.Translate(x, y, 0);
        x = x * (-1);
        y = y * (-1);
    }
}
