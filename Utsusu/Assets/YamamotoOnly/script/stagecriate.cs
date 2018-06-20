using UnityEngine;
using System.Collections;

public class stagecriate : MonoBehaviour
{
    Warp warp;
<<<<<<< HEAD

    public GameObject block, ClearZone, deathzone, neadle, warpin, warpout, BB,
        BajiBlock, bajilisk;
    int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount = 0, warpoutcount = 0, bajicount = 0;
=======
    public GameObject block, ClearZone, deathzone, neadle, warpin, warpout, BB;
    public int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount = 0, warpoutcount = 0;
>>>>>>> origin/honjo
    static int stageNum = 1;


    string[] stage1 = { " b     b        ddddddd",
                        "b   b    b      ddddddd",
                        "bbbbbbbbbbbcccccddddddd",
                        "ddddddddddddddddddddddd"
                        };

    string[] stage2 = { "          ",
                        "E  bb  bbdb  b b            dddddd",
                        "bdb dbbbbdb  b  bbb  bbbbbbdddddd",
                        "dddddddddddddddddddwwdddddddddddd",
                        "",
                        "",
                        "",
                        "E       d                                         ddd",
                        "  WWbbbb     dd                                W  ddd",
                        "       bbbbbb      d                             ddd",
                        "             bbbbbb     dd                       ddd",
                        "                  bbbbbb      d                  ddd",
                        "                        bbbbbb      dd           ddd",
                        "                              bbbbbb B           ddd",
                        "dddddddddddddddddddddddddddddddddddd    w        ddd",
                        "                                    ddddddddddcccddd"
                        };

    string[] stage3 = { " b     b    bb             dddddd",
                        "b   b    b b  b bb         dddddd",
                        "bbbb   bbbbbb  b  bbbbcccccdddddd",
                        "ddddddddddddddddddddddddddddddddd" };

    string[] stage4 = { " b     b     b b b  b      bbbbdddd",
                        "Eb   b    b         bb      bbbbdddd",
                        " bbbbbb  bbbbbbb   b bbbbbbw     bbbdddd",
                        "      dd       b   b      ddddddddddddd",
                        "              bb   bb   bb   bbbb",
                        "             E             b   bb                   dddddd",
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
                        "dddddddddddddddddddddddddddddddddddddddddddddddddd"
    };

    string[] stage9_T ={"       ddd                                                  ",
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

    string[] stage10_T ={"                              bddddd",
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


    string[] stage11_T = {"       d    d  　 dddddd                               ",
                        "bbbbbbbbbbbbbBBwBdddddd                                ",
                        "ddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "ddddd       ddddd dddddd       ddddd dddddd       ddddd",
                        "dddddbWbwbbwdddddWddddddbWbwbbwdddddWddddddbWbwbbwddddd",
                        "d       ddddd dddddd dddddd       ddddd dd      d ddddd",
                        "dbWbwBBwdddddWddddddWddddddbWbwBBwdddddWddBBBBBwdWddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "                            d                          ",
                        "                            d                          ",
                        "                            dbWbbbcccccbbbbbbbbbbbbbbbb",
                       };

    string[] stage12_T= {"             dd   dd  ddd  dd   dddddddddddddddddddddd",
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

    string[] stage13_T = {"               ddd   ddd   ddddddddddddddddddddddddddddddddd",
                        "bWWWbbbbb   bbbbbbbbbbbbbbbbwddddddddddddddddddddddddddddddddd",
                        " d       b    ddd         dd   dd             ddd  ddd        ",
                        "  dd      b   ddd         dd   dd             ddd  ddd        ",
                        "          bbbbbbbbbb   bbbbbbbbbbbbbbbbb   bbbbbbbbbbbbbbccccc",
                        "                    b     dd  dd    ddddb     ddd  ddd    dddd",
                        "                     b    dd  dd    dddd b    ddd  ddd    dddd",
                        "                      bbbbbbbbbbbbbwdddd  bbbbbbbbbbbbbbbwdddd",
                       };

 string[] stage14_T = {"    d   d    b     d   d        ddd      d  d  B  dddddddddw",
                       "             d          b     b        b         ddddddddddd",
                       "bbbbbbbb  bbbbbbBBBBbbbddbb  bbBBBBBbbbbbBBbbbbbwBBbbddddddd",
                       "dddddddd  dddddd    ddddddddddd     dddddddddddddddddd      ",
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

    string[] stage9 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};

    string[] stage10 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};
    string[] stage11 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};

    string[] stage12 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};

    string[] stage13 ={ "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage14 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage15 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage16 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage17 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage18 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage19 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage20 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage21 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage22 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage23 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage24 = { "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccc" };
    



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
            case 9:
                stageCopy = stage9;
                break;
            case 10:
                stageCopy = stage10;
                break;
            case 11:
                stageCopy = stage11;
                break;
            case 12:
                stageCopy = stage12;

                break;
            case 13:
                stageCopy = stage13;
                break;
            case 14:
                stageCopy = stage14;
                break;
            case 15:
                stageCopy = stage15;
                break;
            case 16:
                stageCopy = stage16;
                break;
            case 17:
                stageCopy = stage17;
                break;
            case 18:
                stageCopy = stage18;
                break;
            case 19:
                stageCopy = stage19;
                break;
            case 20:
                stageCopy = stage20;
                break;
            case 21:
                stageCopy = stage21;
                break;
            case 22:
                stageCopy = stage22;
                break;
            case 23:
                stageCopy = stage23;
                break;
            case 24:
                stageCopy = stage24;
                break;
        }

        for (int i = 0; i < stageCopy.GetLength(0); i++)//stageCopyの文字数をカウントしその分だけ回す
        {
            for (int j = 0; j < stageCopy[i].Length; j++)//横？
            {
                switch (stageCopy[i].Substring(j, 1))
                {

<<<<<<< HEAD
                    case "b":   //唯のブロック
                        Instantiate(block, new Vector3(startX + j * massWidth,
                                      startY - i * massHeighth, 0.0f), Quaternion.identity);
=======
                    case "b":
                        Instantiate(block, new Vector3(startX + j * massWidth,
              startY - i * massHeighth, 0.0f), Quaternion.identity);
>>>>>>> origin/honjo
                        break;

                    case "B":	//壊れる床
                        Instantiate(BB, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "c":	//クリアするブロック
                        Instantiate(ClearZone, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "d":	//死ぬブロック
                        Instantiate(deathzone, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "w":	//ワープイン
                        var iw = Instantiate(warpin, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity) as GameObject;
                        iw.name = warpin.name + warpincount;
                        warpincount++;
                        break;

                    case "W":	//ワープアウト
                        var ow = Instantiate(warpout, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity) as GameObject;
                        ow.name = warpout.name + warpin.name + warpoutcount;
                        warpoutcount++;
                        break;

                    case "E":	//バジリスク
                        var baji = Instantiate(bajilisk, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        baji.name = "" + bajicount;
                        bajicount++;
                        break;
                }
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