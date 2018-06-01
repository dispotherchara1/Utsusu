using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class clicker : MonoBehaviour {
    
    int evolition = 0;//new int[3];            //進化素材用1/0配布
    public static float page=1000;     //クリックされた回数(スコア)
    float clicked = 1;                  //クリック用変数
    float famiport = 0, famiport_yen = 10, famicount = 1;//ファミポート用変数
    int i = 0,minaspage=100,Maxclicke=10;
    private void Start()
    {    }
    private void Update()
    {
        page +=(famiport) *Time.deltaTime;//一秒ごとにファミポートの数1万円増えるよ！
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
            page += clicked;
    }
    public float Getfamiport_yen()
    {
        return famiport_yen;
    }
    public void SetCliced()
    {
        if (evolition == i&&page>=minaspage)
        {
            page -= minaspage;
            clicked = Maxclicke;
            evolition ++;
            i++;
            minaspage *= 10;
            Maxclicke *= 10;
        }
    }
    public int Getevo()
    {
        return evolition;
    }
}
