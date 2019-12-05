using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonEventTest : MonoBehaviour {

    Button button;
    EventTrigger trigger;

    void Start()
    {
        button = GetComponent<Button>();




        trigger = GetComponent<EventTrigger>();

        EventTrigger.Entry ENTER = new EventTrigger.Entry();
        EventTrigger.Entry EXIT = new EventTrigger.Entry();
        EventTrigger.Entry CLICK = new EventTrigger.Entry();
        EventTrigger.Entry DOWN = new EventTrigger.Entry();
        EventTrigger.Entry UP = new EventTrigger.Entry();

        ENTER.eventID = EventTriggerType.PointerEnter;  //鼠标进入事件
        EXIT.eventID = EventTriggerType.PointerExit;  //鼠标滑出事件
        CLICK.eventID = EventTriggerType.PointerClick;  //鼠标点击事件
        DOWN.eventID = EventTriggerType.PointerDown;  //鼠标按下事件
        UP.eventID = EventTriggerType.PointerUp;   //鼠标抬起事件

        ENTER.callback.AddListener(OnMyPointerEnter);
        EXIT.callback.AddListener(OnMyPointerExit);
        CLICK.callback.AddListener(OnMyPointerClick);
        DOWN.callback.AddListener(OnMyPointerDown);
        UP.callback.AddListener(OnMyPointerUp);

        trigger.triggers.Add(ENTER);
        trigger.triggers.Add(EXIT);
        trigger.triggers.Add(CLICK);
        trigger.triggers.Add(DOWN);
        trigger.triggers.Add(UP);
    }

    public void OnMyPointerEnter(BaseEventData pointData)
    {
        print("PointerEnter");
    }

    public void OnMyPointerExit(BaseEventData pointData)
    {
        print("PointerExit");
    }

    public void OnMyPointerClick(BaseEventData pointData)
    {
        print("PointerClick");
    }

    public void OnMyPointerDown(BaseEventData pointData)
    {
        print("PointerDown");
    }

    public void OnMyPointerUp(BaseEventData pointData)
    {
        print("PointerUp");
    }
}
