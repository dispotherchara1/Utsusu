using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public Canvas select, title;
    bool onselect;
    stagecriate stagecriate;//LoadScene(4)はゲームシーンに飛ぶよ。
    int selectNum = 1;
    public Text[] text = { };
    public Text text1, text2, text3, text4,
                text5, text6, text7, text8;
    public mynumber MyNum;
    enum StageSelectType
    {
        Easy,
        Normal,
        Hard,
    };
    StageSelectType stageselectType;
    private void Start()
    {
        //title.enabled = false;
        select.enabled = false;
        onselect = false;
    }
    void Update()
    {
        if (onselect == true)
        { select.enabled = true; title.enabled = false; }
        //セレクトがtrueの時セレクト用のボタンが出ます

        switch (stageselectType)
        {
            case StageSelectType.Easy:
                selectNum = 0;
                text1.text = "1";
                text2.text = "2";
                text3.text = "3";
                text4.text = "4";
                text5.text = "5";
                text6.text = "6";
                text7.text = "7";
                text8.text = "8";
                break;

            case StageSelectType.Normal:
                selectNum = 8;
                text1.text = "9";
                text2.text = "10";
                text3.text = "11";
                text4.text = "12";
                text5.text = "13";
                text6.text = "14";
                text7.text = "15";
                text8.text = "16";
                break;

            case StageSelectType.Hard:
                selectNum = 16;
                text1.text = "17";
                text2.text = "18";
                text3.text = "19";
                text4.text = "20";
                text5.text = "21";
                text6.text = "22";
                text7.text = "23";
                text8.text = "24";
                break;
        }
    }
    public void Next()
    {
        if (stageselectType < StageSelectType.Hard)
        {
            stageselectType++;
        }
    }

    public void Back()
    {
        if (stageselectType > StageSelectType.Easy)
        {
            stageselectType--;
        }
    }

    stagecriate StageCriate;//LoadScene(4)はゲームシーンに飛ぶよ。
    public void Select()
    {
        onselect = true;//セレクトをtrueに
    }

    public void Title()
    {
        SceneManager.LoadScene(0);//セレクトを再読み込み
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(5);
    }

    public void Stage()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 1));
    }

    public void Stage2()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 2));
    }

    public void Stage3()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 3));
    }

    public void Stage4()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 4));
    }

    public void Stage5()
    {
       SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 5));
    }

    public void Stage6()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 6));
    }

    public void Stage7()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 7));
    }

    public void Stage8()
    {
        SceneManager.LoadScene(4);
        MyNum.SetstageNum(+(selectNum + 8));
    }
    public int selectnumber()
    {
        return selectNum;
    }
}