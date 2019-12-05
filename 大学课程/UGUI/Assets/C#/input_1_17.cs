using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class input_1_17 : MonoBehaviour
{
    public Text text_jg;
    public InputField inputField1;
    public InputField inputField2;
    public InputField inputField_tc;
    public GameObject panel_tc;

    public void jisuan()
    {
        if (inputField1.text != "" && inputField1.text != "")
        {
            text_jg.text = (int.Parse(inputField1.text) - int.Parse(inputField2.text)).ToString();
        }
        else
        {

            text_jg.text = "请输入要运算的数值Num1和Num2...";
        
        }

       
            
    }
    public void tanchu()
    {
        panel_tc.gameObject.SetActive(true);
 
    }

    public void yes()
    {
        text_jg.text = inputField_tc.text;
        panel_tc.gameObject.SetActive(false);

    }

    public void no()
    {
       
        panel_tc.gameObject.SetActive(false);

    }








}
