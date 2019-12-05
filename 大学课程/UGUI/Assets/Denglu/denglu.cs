using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using System.Xml;


public class denglu : MonoBehaviour {
    public Image image_zc;
    public Image image_ts;
    public Text text_info;
    public Text text_ts;
    private string _xmlpath;


    //注册变量
    public InputField inputField_name_zc;
    public InputField InputField_password1_zc;
    public InputField InputField_password2_zc;
    public InputField InputField_Telephone_zc;
    public InputField InputField_QQ_zc;

    //登录变量
    public InputField inputField_name_DL;
    public InputField InputField_password_DL;

    void Start()
    {
         _xmlpath = Application.dataPath + "/user.xml";

        if (!File.Exists(_xmlpath))
        { 
            //新建xml实例
            XmlDocument xmlDoc = new XmlDocument();

            //创建根节点，最上层的节点
            XmlElement root = xmlDoc.CreateElement("Root");
            xmlDoc.AppendChild(root);//把root添加到xmlDoc文档中

            //创建用户子节点,根节点的子节点
            XmlElement user = xmlDoc.CreateElement("User");
            user.SetAttribute("user_name","Differ");
            user.SetAttribute("user_password", "12121320pzh");
            user.SetAttribute("user_Tel", "15001949637");
            user.SetAttribute("user_QQ", "1745149920");
            root.AppendChild(user);//把user添加到root元素中
            xmlDoc.Save(_xmlpath );
            print("xml creat success!");
            //结果：xmlDoc/root/user
        
        }
    
    }



    public void Quit()
    { 
#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying =false;
#else
        Application.Quit();
#endif
    
    }

    public void open_zc()
    {
        image_zc.gameObject.SetActive(true);
    
    }
    public void close_zc()
    {
        image_zc.gameObject.SetActive(false);

    }
    public void close_ts()
    {
        image_ts.gameObject.SetActive(false);

    }


    public void open_ts(string str)
    {
        image_ts.gameObject.SetActive(true );
        text_info.text = str;
        text_ts.text  = str;
    
    }



    public void zc()
    {
        if (InputField_password1_zc.text != InputField_password2_zc.text)
        {
            open_ts("两次密码输入不同，请重新输入");
             return;
        }

        if (inputField_name_zc.text == "" || InputField_password1_zc.text == "" || InputField_password2_zc.text == "" || InputField_Telephone_zc.text == "" || InputField_QQ_zc.text == "")
        {
            open_ts("信息填写不完整,请重新输入！");
            return;//跳出注册框？？？？？？？？？？？？？？？？？？？。。。。。。怎样跳出的？
        }


        //判断用户名是已经否被注册
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(_xmlpath );
        XmlNodeList nodeList = xmlDoc.SelectSingleNode("Root").ChildNodes ;
        foreach(XmlElement xe in nodeList )
        {
            if (xe.GetAttribute("user_name") == inputField_name_zc.text)
        {
            open_ts("该用户名已经被占用，请更换用户名！");
            return;
        }

        
        }

        //把注册用户保存到用户deta
        //1)取得根节点
        XmlNode root = xmlDoc.SelectSingleNode("Root");

        //创建User辛节点
        XmlElement user = xmlDoc.CreateElement("User");
       //设置属性
        user.SetAttribute("user_name", inputField_name_zc.text);
        user.SetAttribute("user_password", InputField_password1_zc.text);
        user.SetAttribute("user_Tel", InputField_Telephone_zc.text);
        user.SetAttribute("user_QQ", InputField_QQ_zc.text);

        //将新节点加入根节点
        root.AppendChild(user);

        //保存文件
        xmlDoc.Save(_xmlpath );
        open_ts("注册成功！");

        //清空已注册信息

        inputField_name_zc.text = "";
        InputField_password1_zc.text = "";
        InputField_password2_zc.text = "";
        InputField_Telephone_zc.text = "";
        InputField_QQ_zc.text = "";
       

    }




    public void userdenglu()
    { 
    if(inputField_name_DL.text==""||InputField_password_DL.text=="")
    {
        open_ts("用户名或密码不能为空！");
        return;
    }


        //判断用户名是否已经被注册
           XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(_xmlpath );
        XmlNodeList nodeList = xmlDoc.SelectSingleNode("Root").ChildNodes ;
        foreach (XmlElement xe in nodeList)
        {
            if (xe.GetAttribute("user_name") == inputField_name_DL.text)

            {
                var passWord = xe.GetAttribute("user_password");
                if (InputField_password_DL.text == passWord)
                {
                    open_ts("登录成功！");
                    Application.OpenURL("http://www.baidu.com");
                    return;
                }
                else 
                {
                    open_ts("密码错误，请重新输入密码！");
                    inputField_name_DL.text = xe.GetAttribute("user_name");
                    InputField_password_DL.text = "";
                    return;
                
                }
            
            }
        }

        open_ts("该账户尚未注册，请注册！");
    
    }
      
    
    
    }





