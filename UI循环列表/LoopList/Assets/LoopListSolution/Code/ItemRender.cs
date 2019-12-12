using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemRender : DynamicInfinityItem,IPointerClickHandler
{
    public Text m_TxtName;

    public Button m_Btn;
	// Use this for initialization
	void Start () {
		m_Btn.onClick.AddListener(() =>
		{
            print("Click "+mData.ToString());
		});
	}

    protected override void OnRenderer()
    {
        base.OnRenderer();
        m_TxtName.text = mData.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSelectHandler(this);
    }
}
