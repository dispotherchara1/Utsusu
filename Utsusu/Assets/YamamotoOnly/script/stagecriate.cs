using UnityEngine;
using System.Collections;

public class stagecriate : MonoBehaviour
{
    Warp warp;

    public GameObject block, ClearZone, deathzone, neadle,warpin,warpout,BB,
        BajiBlock,bajilisk;
    int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount = 0, warpoutcount = 0, bajicount = 0;
    static int stageNum = 1;

    //string[] stage1 = { " b     b        ddddddd",
                        //"b   b    b      ddddddd",
                        //"bbbbbbbbbbbcccccddddddd",
                        //"ddddddddddddddddddddddd"
                        //};

    string[] stage2 = { "          ",
                        "  bb  bbdb  b b            dddddd",
                        "bdb dbbbbdb  b  bbb  bbbbbbdddddd",
                        "dddddddddddddddddddwwdddddddddddd",
                        "",
                        "",
                        "",
                        "      d                                         ddd",
                        "WWbbbb     dd                                W  ddd",
                        "      bbbbbb      d                             ddd",
                        "            bbbbbb     dd                       ddd",
                        "                  bbbbbb      d                 ddd",
                        "                        bbbbbb     dd           ddd",
                        "                              bbbbbb B          ddd",
                        "dddddddddddddddddddddddddddddddddddd    w       ddd",
                        "                                    ddddddddddccddd"
                        };

    string[] stage3 = { " b     b    bb             dddddd",
                        "b   b    b b  b bb         dddddd",
                        "bbbb   bbbbbb  b  bbbbcccccdddddd",
                        "ddddddddddddddddddddddddddddddddd" };

    string[] stage4 = { " b     b     b b b  b      bbbbdddd",
                        "b   b    b         bb      bbbbdddd",
                        "bbbbbb  bbbbbbb   b bbbbbbw     bbbdddd",
                        "      dd       b   b      ddddddddddddd",
                        "              bb   bb   bb   bbbb",
                        "                           b   bb                   dddddd",
                        "               Wbbb   bb            b               dddddd",
                        "WBB          ddd   bb bbbbbbbbbb bbb bbbb bbbwdddddddddddd",
                        "   BB      ddd       ddddddddddddddddddddddddddddddddddddd",
                        "     BBB             dddddd",
                        "        BBBBBBBccccccdddddd",
                        "ddddddddddddddddddddddddddd"};

    string[] stage5 = { "   bbb       bbbw      Wbbbb           dddddd",
                        "bbbbbbbbbbbw       bbb      Wbbbbbcccccdddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddd"};

    string[] stage6 = {" bW    b     b b bdddd",
                        "b   b    b      bbdddd",
                        "bbbbbbbbbbbbbb  bdddd",
                        "          dddd  ddddd",
                        "          dddd  ddddd",
                        "          dddd  ddddd",
                        "          dddd  ddddd",
                        "          dddd  ddddd",
                        "            dd  dddd",
                        "",
                        "                d        dddddd",
                        "           W  bb wwccccccdddddd",
                        "dddddddddddddddddddddddddddddd"};

    string[] stage7 = { "        ddddddddddddddddddddddddddddddddddd",
                        "              dddddbbbb   bb     db           ddddddddd",
                        "bbbbbbbwbbwbbwdddddbbbbbb        bb           ddddddddd",
                        "dddddddddddddddddbbbbbbbbWbbbbbbbbbbbbbbbbbbbbddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddd",
                        "d ddddddddddddddd",
                        "dWddddddddddddddd",
                        "",
                        "",
                        "",
                        "",
                        "           dddddd",
                        "Wbbbbbccccccdddddd",
                        "dddddddddddddddddd"};

    string[] stage8 = { "       dd    d    d  d   dddd         dd  W    dd",
                        "bbbbbbbbbbbBBBWBBBBbbbwbbdddd         dd    w  dd",
                        "bbbbbbbbbbbddddddddbbbbbbdddd         dd      wdd",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb         ddddddddddd",
                        "d    dd                               ddddddddddd",
                        "dWBBBddbw                                   ",
                        "ddd  dd                                   ",
                        "ddd  dd",
                        "ddd  dd",
                        "ddd  dd",
                        "ddd  dd",
                        "ddd",
                        "dddBWBBBBBBBBBBBBBBB  BB  BB  BB  BB  Wccccccdddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddd"};

    string[] stage9 = { "       ddd                                                  ",
                        "BBBBBBwddd                                                  ",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "d       b      b      b      b      b      d      b     bddd",
                        "d       b      b      b      b      d      d      d     bddd",
                        "d      bdb    bdb    ddd    ddd    ddd    ddd    ddd    bddd",
                        "d       b      d      b      d      d      d     ddd    bddd",
                        "d                                                       bddd",
                        "bbWWbbb   bbbb   bbbb   bbbb   bbbb   bbbb   bbbb   bbbwdddd",
                        "ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "dddddddddddddddddddddddddddcccccdddddddddddddddddddddddddddd",
                       };

    string[] stage10 =  {"                              bddddd",
                         "                              bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbb                           bddddd",
                         "bbbwwwccbwwwccbwwwccbwwwccbwwwbddddd",
                         "dddddddddddddddddddddddddddddddddddd",
                         "ddd   ddd   ddd   ddd   ddd   dddddd",
                         "dddWWWdddWWWdddWWWdddWWWdddWWWdddddd",
                        };

    string[] stage11 = {"      d     d   bdddd                                  ",
                        "bbbbbbbbbbbbbBBwbdddd                                  ",
                        "ddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "ddddd       ddddd dddddd       ddddd dddddd       ddddd",
                        "dddddbWbwbbwdddddWddddddbWbwbbwdddddWddddddbWbwbbwddddd",
                        "d       ddddd dddddd dddddd       ddddd dd      d ddddd",
                        "dbWbwBBwdddddWddddddWddddddbWbwBBwdddddWddBBBBBwdWddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "                             b                         ",
                        "                             b                         ",
                        "                             bWbbbccccccccccbbbbbbbbbbb",
                       };

    string[] stage12= {"             dd   dd  ddd  dd   dddddddddddddddddddddd",
                        "bbbbbbb   bbbbbbbbbbbbbbbbbbb       dddddddddddddddddd",
                        "       b                     dBb      dd   ddddddddddd",
                        "        b                    dddddBBbbdd    dddddddddd",
                        "         b       dd          dddddddddddd   dd  dddddd",
                        "          bbbbbbbbb        dd    ddddddddBBbbb   ddddd",
                        "                   bbbddbbbbb    ddddddddddddd    dddd",
                        "                                 dddddddddddddd    ddd",
                        "                                 d    d    d   d      ",
                        "                             dbbbdbbbbbbbbbbbbbdcccccc",
                       };

    string[] stage13 = {"               ddd   ddd     ddddddddddddddddddddddddddddddddd",
                        "bWWWbbbbb   bbbbbbbbbbbbbbbbwddddddddddddddddddddddddddddddddd",
                        " d       b    ddd         dd   dd             ddd  ddd        ",
                        "  dd      b   ddd         dd   dd             ddd  ddd        ",
                        "          bbbbbbbbbb   bbbbbbbbbbbbbbbbb   bbbbbbbbbbbbbbccccc",
                        "                    b     dd  dd    ddddb     ddd  ddd    dddd",
                        "                     b    dd  dd    dddd b    ddd  ddd    dddd",
                        "                      bbbbbbbbbbbbbwdddd  bbbbbbbbbbbbbbbwdddd",
                       };

    string[] stage1 = {"       d   d    b     d   d     ddd      d  d  B  dddddddddw",
                       "             d          b     b        b         ddddddddddd",
                       "bbbbbbbb  bbbbbbBBBBbbbddbb  bbBBBBBbbbbbBBbbbbbwBBbbddddddd",
                       "dddddddddddddddd    ddddddddddd     dddddddddddddddddd      ",
                       "dddddddddddddddd    ddddddddddd     dddddddddddddddddd      ",
                       "dddddddddddddddd    dddddddddddd    ddddddddd     ddddbWcccc",
                       "dddddddddddddddd    dddddddddddd    ddddddddd     dddddddddd",
                       "dddddddddddddddd    dddddddddddd    d   ddddd  W  dddddddddd",
                       "dddddddddddddddddddddddddddddddd    d   ddddd     dddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   dddddddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   d                   ",
                       "ddddddddddddddddddddddddddddddddd   d   d                   ",
                       "ddddddddddddddddddddddddddddddddd   d   d                   ",
                       "ddddddddddddddddddddddddddddddddddddd   d                   ",
                       "ddddddddddddddddddddddddddddddddddddd   d                   ",
                       "ddddddddddddddddddddddddddddddddddddd   d                   ",
                       "ddddddddddddddddddddddddddddddddddddd   dddddddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddd                       ",
                       "dddddddddddddddddddddddddddddddddddddccccccccccccccccccccccc",
                       };

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

                    case "B":
                        Instantiate(BB, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "c":
                        Instantiate(ClearZone, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "d":
                        Instantiate(deathzone, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "w":
                        var iw = Instantiate(warpin, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity) as GameObject;
                        iw.name = warpin.name + warpincount;
                        warpincount++;
                        break;

                    case "W":
                        var ow = Instantiate(warpout, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity) as GameObject;
                        ow.name = warpout.name + warpin.name + warpoutcount;
                        warpoutcount++;
                        break;

                    case "e":
                        Instantiate(BajiBlock, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        name = ""+bajicount;
                        break;

                    case "E":
                        Instantiate(bajilisk, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        name = "bajirisk";
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