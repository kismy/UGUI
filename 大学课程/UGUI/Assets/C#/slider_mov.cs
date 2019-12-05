using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slider_mov : MonoBehaviour {
    public Light point_light;
    public AudioSource myAudio;

    public Text Text_light_Value;
    public Text Text_volume_value;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void light_v(float v)
    {
        point_light.intensity = v;

        Text_light_Value.text = v.ToString(); 
    
    }

    public void volume_v(float v)
    {
        myAudio.volume  = v;
        Text_volume_value.text = v.ToString(); 


    }


}
