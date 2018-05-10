using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class clicker : MonoBehaviour {

    public static float page=0;

    public float famiport=0,famiport_yen=100,famicount=1;

    private void Start()
    {    }
    private void Update()
    {
        page +=(famiport) *Time.deltaTime;
    }

    private void Awake()
    {
        //イベント作成
        EventTrigger.Entry pressDown = new EventTrigger.Entry();
        pressDown.eventID = EventTriggerType.PointerDown;       //イベントのタイプ設定
        pressDown.callback.AddListener((data) => { Page_masu(); });   //メソッド登録

        //イベントトリガーにイベント追加
        //GetComponent<EventTrigger>().triggers.Add(pressDown);
    }
    public void famiport_get()
    {
        if (page >= famiport_yen)
        {
            page -= famiport_yen;
            famiport++; famicount++;
            famiport_yen = (famiport_yen + (famicount/0.5f));
        }
    }

    public void Page_masu()
    {
            page += 1;        
    }
}
