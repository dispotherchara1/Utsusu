using UnityEngine;
using System.Collections;

public class stagecriate : MonoBehaviour
{
    Warp warp;
    public GameObject block, ClearZone, deathzone, neadle,warpin,warpout;
    public int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount=0, warpoutcount=0;
    public static void StageNum(int num)
    { //staticをつけてシーンを移動しても保存できる
            stageNum = num;
    }
    static int stageNum = 1;
    string[] stage1 = { " b     b          ddddddd",
                        "b   b    b        ddddddd",
                        "bbbbbbbbbbbcccccddddddd",
                        "                ddddddd" };

    string[] stage2 = { "  b    b b                  dddddd",
                        "bbb bb  bbbb  b bbbbbcccccdddddd",
                        "   d  dd    dd d          dddddd"};

    string[] stage3 = { " b     b    bb               dddddd",
                        "b   b    b b  b bb           dddddd",
                        "bbbb   bbbbbb  b  bbbbcccccdddddd",
                        "     dd      dd dd         dddddd" };

    string[] stage4 = { " b     b     b b b  b      bbbbdddd",
                        "b   b    b         bb      bbbbdddd",
                        "bbbbbb  bbbbbbb   b bbbbbbw     bbbdddd",
                        "      dd       b   b      ddddddddddddd",
                        "              bb   bb   bb   bbbb",
                        "                           b   bb                   dddddd",
                        "               Wbbb   bb            b               dddddd",
                        "             ddd   bb bbbbbbbbbb bbb bbbb bbbcccccdddddd",
                        "          ddd        d          d   d    d        dddddd"};

    string[] stage5 = { "   bbb       bbbw      Wbbbb           dddddd",
                        "bbbbbbbbbbbw       bbb      Wbbbbbcccccdddddd",
                        "           dddddddddddddddddd          dddddd"};

    string[] stage6 = { "     bbbbbb",
                        "bbbbbbbbbbbbbb",
                        };

    string[] stage7 = { "      bbbbb",
                        "bbbbbbbbbbb" };

    string[] stage8 = { "       bbbb",
                        "bbbbbbbbbbb" };

    string[] stageCopy = { "" };

    void Start()
    {
        switch (stageNum)//stageを判別、ステージ番と同じコードのStringをStageCopyにコピペする。
        {
            case 1:
                stageCopy = stage1;
                break;
            case 2:
                stageCopy = stage2;
                break;
            case 3:
                stageCopy = stage3;
                break;
            case 4:
                stageCopy = stage4;
                break;
            case 5:
                stageCopy = stage5;
                break;
            case 6:
                stageCopy = stage6;
                break;
            case 7:
                stageCopy = stage7;
                break;
            case 8:
                stageCopy = stage8;
                break;
        }

        for (int i = 0; i < stageCopy.GetLength(0); i++)//stageCopyの文字数をカウントしその分だけ回す
        {
            for (int j = 0; j < stageCopy[i].Length; j++)//横？
            {
                switch (stageCopy[i].Substring(j, 1)) {
                    case "b": Instantiate(block, new Vector3(startX + j * massWidth,
                    startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "c":
                        Instantiate(ClearZone, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "d":
                        Instantiate(deathzone, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "w":
                        var iw = Instantiate(warpin, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity)as GameObject;
                    iw.name = warpin.name+warpincount;
                    warpincount++;
                        break;

                    case "W":
                    var ow = Instantiate(warpout, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity)as GameObject;
                    ow.name = warpout.name+warpin.name+warpoutcount;
                    warpoutcount++;
                        break;
                }
                /*if (stageCopy[i].Substring(j, 1) == "b")
                {
                }
                if (stageCopy[i].Substring(j, 1) == "c")
                {
                }
                if (stageCopy[i].Substring(j, 1) == "d")
                {
                }
                if (stageCopy[i].Substring(j, 1) == "w")
                {
                    
                }
                if (stageCopy[i].Substring(j, 1) == "W")
                {
                }*/
            }
        }
    }
    public static void GetStageNum(int a)//staticをつけてシーンを移動しても保存できる
    {
        stageNum = a;
    }
    public static int RequestStageNum()
    {
        return stageNum;
    }
}