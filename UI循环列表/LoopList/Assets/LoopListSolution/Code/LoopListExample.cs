using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoopListExample : MonoBehaviour
{
    public DynamicInfinityListRenderer m_Dl;

    public int DataLenght=500;
    public int moveToData=24;
    public int removeData=6;
    public int AddData=501;

    public Button m_BtnSetDatas;

    public Button m_BtnMove2Data;

    public Button m_BtnRemoveData;

    public Button m_BtnAddData;

    private Text SetDatasText;
    private Text Move2DataText;
    private Text RemoveDataText;
    private Text AddDataText;
    void Start () {
        SetDatasText = m_BtnSetDatas.transform.Find("Text").GetComponent<Text>();
        Move2DataText = m_BtnMove2Data.transform.Find("Text").GetComponent<Text>();
        RemoveDataText = m_BtnRemoveData.transform.Find("Text").GetComponent<Text>();
        AddDataText = m_BtnAddData.transform.Find("Text").GetComponent<Text>();

        m_Dl.InitRendererList(OnSelectHandler,null);
        m_BtnSetDatas.onClick.AddListener(() =>
        {
            List<int> datas = new List<int>();
            for (int i = 0; i < DataLenght; ++i)
            {
                datas.Add(i);
            }
            m_Dl.SetDataProvider(datas);

        });

	    m_BtnMove2Data.onClick.AddListener(() =>
	    {
	        if (m_Dl.GetDataProvider() != null)
	        {
	            m_Dl.LocateRenderItemAtTarget(moveToData, 1);
	        }
	        else
	        {
	            print("先设置数据吧");
            }

	    });

	    m_BtnRemoveData.onClick.AddListener(() =>
	    {
	        if (m_Dl.GetDataProvider() != null)
	        {
	            if (m_Dl.GetDataProvider().Contains(removeData))
	            {
	                m_Dl.GetDataProvider().Remove(removeData);
	                m_Dl.RefreshDataProvider();
	            }
	            else
	            {
	                print("找不到数据");
	            }
            }
	        else
	        {
	            print("先设置数据吧");
	        }	                     
	    });

        m_BtnAddData.onClick.AddListener(() =>
        {
            if (m_Dl.GetDataProvider() != null)
            {
                m_Dl.GetDataProvider().Add(AddData);
                m_Dl.RefreshDataProvider();
            }
            else
            {
                print("先设置数据吧");
            }
        });
    }

    void OnSelectHandler(DynamicInfinityItem item)
    {
        print("on select "+item.ToString());
    }

    private void Update()
    {
        SetDatasText.text = string.Format("设置数据长度{0}（0-{1}）", DataLenght, DataLenght-1);
        Move2DataText.text = string.Format("移动至数据{0}", moveToData);
        RemoveDataText.text = string.Format("移除数据{0}", removeData);
        AddDataText.text = string.Format("添加数据{0}", AddData);
    }

    public void OnValueChange(Vector2 value)
    {
        if (value.y < 0 || value.y > 1)
            return;
        m_Dl.UpdateRender();
    }
}
