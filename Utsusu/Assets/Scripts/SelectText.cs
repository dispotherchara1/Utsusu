using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SelectText : MonoBehaviour
{
    static int selectNum = 0;
    public Text text1, text2, text3, text4,
                text5, text6, text7, text8;
    enum StageSelectType
    {
        Easy,
        Normal,
        Hard,
    };
    StageSelectType stageSelectType;

    public static int GetSelectNum()
    {
        return selectNum;
    }

    void Update()
    {
        switch (stageSelectType)
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
        Debug.Log(selectNum);
    }

    /*
    public int SetSelectNum(int a)
    {
        return selectNum = selectNum + a;
    }
    */
    public void SetSelectNum(int a)
    {
        selectNum =  a;
    }


    public void Next()
    {
        if (stageSelectType < StageSelectType.Hard)
        {
            stageSelectType++;
        }
    }

    public void Back()
    {
        if (stageSelectType > StageSelectType.Easy)
        {
            stageSelectType--;
        }
    }
}
