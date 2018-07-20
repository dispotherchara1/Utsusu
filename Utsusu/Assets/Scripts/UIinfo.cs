using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class UIinfo : MonoBehaviour
{
    int stage,selectstg;
    public SceneChange scenechange;
    public Canvas select, title;
    bool onselect;
    public Text[] text = { };
    enum StageSelectType
    {
        Easy,
        Normal,
        Hard,
    };
    StageSelectType stageselectType;
    // Use this for initialization
    void Start ()
    {
        select.enabled = false;
        onselect = false;
        selectstg = scenechange.selectnumber();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //セレクトがtrueの時セレクト用のボタンが出ます
        if (onselect == true)
        { select.enabled = true; title.enabled = false; }



        switch (stageselectType)
        {
            case StageSelectType.Easy:
                scenechange.Setselectnumber(0);
                text[0].text = "1";
                text[1].text = "2";
                text[2].text = "3";
                text[3].text = "4";
                text[4].text = "5";
                text[5].text = "6";
                text[6].text = "7";
                text[7].text = "8";
                for (int i = 0; i < 8; i++)
                {
                    if (scenechange.Getflg(i + scenechange.selectnumber()+1) == null) { text[i].enabled = false; }
                }
                break;

            case StageSelectType.Normal:
                scenechange.Setselectnumber(8);
                text[0].text = "9";
                text[1].text = "10";
                text[2].text = "11";
                text[3].text = "12";
                text[4].text = "13";
                text[5].text = "14";
                text[6].text = "15";
                text[7].text = "16";
                for (int i = 0; i < 8; i++)
                {
                    if (scenechange.Getflg(i + scenechange.selectnumber()+1) == null) { text[i].enabled = false; }
                }
                break;

            case StageSelectType.Hard:
                scenechange.Setselectnumber(16);
                text[0].text = "17";
                text[1].text = "18";
                text[2].text = "19";
                text[3].text = "20";
                text[4].text = "21";
                text[5].text = "22";
                text[6].text = "23";
                text[7].text = "24";
                for (int i = 0; i < 8; i++)
                {
                    if (scenechange.Getflg(i + scenechange.selectnumber()) == null) { text[i].enabled = false; }
                }
                break;
        }
        //if (scenechange.selectnumber() != selectstg)
        //{
        //    selectstg = scenechange.selectnumber();
        //    for (int i = 0; i < 8; i++)
        //    {
        //        if (scenechange.Getflg(i + scenechange.selectnumber()) == null) { text[i].enabled = false; }
        //    }
        //}
    }
    public void Next()
    {
        if (stageselectType < StageSelectType.Hard)//ステージ難易度を次に変える
        {
            stageselectType++;
        }
    }

    public void Back()
    {
        if (stageselectType > StageSelectType.Easy)//ステージ難易度を後ろに変える
        {
            stageselectType--;
        }
    }

    stagecriate StageCriate;//LoadScene(2)はゲームシーンに飛ぶよ。
    public void Select()
    {
        onselect = true;//セレクトをtrueに
    }

    //　ゲーム終了ボタンを押したら実行する
    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }
}
