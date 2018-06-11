﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    stagecriate stagecriate;//LoadScene(4)はゲームシーンに飛ぶよ。
    int selectNum = 0;
    public Text text1, text2, text3, text4,
                text5, text6, text7, text8;
    enum StageSelectType
    {
        Easy,
        Normal,
        Hard,
    };
    StageSelectType stageselectType;

    void Update()
    {
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

    public void Select()
    {
        SceneManager.LoadScene("select");
    }

    public void Title()
    {
        SceneManager.LoadScene("title");
    }

    public void Stage()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(1 + selectNum);
    }

    public void Stage2()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(2 + selectNum);
    }

    public void Stage3()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(3 + selectNum);
    }

    public void Stage4()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(4 + selectNum);
    }

    public void Stage5()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(5 + selectNum);
    }

    public void Stage6()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(6 + selectNum);
    }

    public void Stage7()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(7 + selectNum);
    }

    public void Stage8()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(8 + selectNum);
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
}
