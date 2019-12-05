using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems ;

public class zhezhao : MonoBehaviour {
    public Image image1;
    public float i=0.0f;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {

        image1.type = Image.Type.Filled;
        image1.fillMethod = Image.FillMethod.Radial360;
        image1.fillAmount = i;

        if (i >= 1) i = 0;
        i=i+0.001f;

	
	}
}
