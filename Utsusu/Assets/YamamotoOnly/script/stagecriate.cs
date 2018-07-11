using UnityEngine;
using System.Collections;

public class stagecriate : MonoBehaviour
{
    Warp warp;
    public GameObject block, ClearZone, deathzone, neadle, warpin, warpout, BB,
                      BajiBlock, bajilisk;
    int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount = 0, warpoutcount = 0, bajicount = 0;
    static int stageNum = 1;
    public SceneChange MyNum;

    //左から６ブロック目がスライムの誕生地点です。
    string[] stage1 = { "      b     b        ddddddd",
                        "     b   b    b      ddddddd",
                        "dddddbbbbbbbbbbbcccccddddddd",
                        "dddddddddddddddddddddddddddd"
                        }; 

    string[] stage2 = { "",
                        "E        bb  bbdb  b b            dddddd                                ",
                        "     bbbdb dbbbbdb  b  bbb  bbbbbbdddddd                                ",
                        "     bdddddddddddddddddddbwwdddddddddddd                                ",
                        "                                                                dddddddd",
                        "                                                                dddddddd",
                        "                                                                dddddddd",
                        "   E         d                                                  dddddddd",
                        "     bbbWWbbbb    dd                                      W     dddddddd",
                        "              bbbbbb    d                                       dddddddd",
                        "                   bbbbbb    dd                                 dddddddd",
                        "                         bbbbbb     d                           dddddddd",
                        "                               bbbbbb    dd                     dddddddd",
                        "                                     bbbbbbBBB                  dddddddd",
                        " dddddddddddddddddddddddddddddddddddddddddd   w                 dddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddcccccdddddddd"
                        };

    string[] stage3 = { "      b     b    bb             dddddd",
                        "     b   b    b b  b bb         dddddd",
                        "dddddbbbb   bbbbbb  b  bbbbcccccdddddd",
                        "dddddddddddddddddddddddddddddddddddddd" };

    string[] stage4 = { "      b     b     b b b  b      bbbbdddd",
                        "E    b   b    b         bb      bbbbdddd",
                        "    bbbbbbbbb  bbbbbbb   b bbbbbbw     bbbdddd",
                        "      dd       b   b      ddddddddddddd",
                        "              bb   bb   bb   bbbb",
                        "          E                b   bb                   dddddd",
                        "               Wbbb   bb            b               dddddd",
                        "WBB          ddd   bb bbbbbbbbbb bbb bbbb bbbwdddddddddddd",
                        "   BB      ddd       ddddddddddddddddddddddddddddddddddddd",
                        "     BBB             dddddd",
                        "        BBBBBBBccccccdddddd",
                        "ddddddddddddddddddddddddddd"};

    string[] stage5 = { "   bbb       bbbw      Wbbbb           dddddd",
                        "bbbbbbbbbbbw       bbb      Wbbbbbcccccdddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddd"
                            };

    string[] stage6 = {" bW    b     b b bdddddddddddd",
                        "b   b    b      bbddddddddddd",
                        "bbbbbbbbbbbbbb  bdddddddddddd",
                        "          dddd  ddddddddddddd",
                        "          dddd  ddddddddddddd",
                        "          dddd  ddddddddddddd",
                        "          dddd  dddddddddddd",
                        "          dddd  dddddddddd",
                        "            dd  ddddddd",
                        "W",
                        "  BB            d        dddddddddddddddddd",
                        "     E     W  bb wwwcccccdddddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddd"};

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

    string[] stage8 = { "       dd    d    d  d   ddddddddddddddd  W    dddddddddddddd",
                        "bbbbbbbbbbbBBBWBBBBbbbwbbddddddddddddddd    w  dddddddddddddd",
                        "bbbbbbbbbbbddddddddbbbbbbddddddddddddddd      wdddddddddddddd",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddddddddddddddddddddddddd",
                        "d    dd                               ddddddddddddddddddddddd",
                        "dWBBBddbwBBB                                 dddddddddddddddd",
                        "ddd  dd     ddd                              dddddddddddddddd",
                        "ddd  dd  ddd                                 dddddddddddddddd",
                        "ddd  dd                                      dddddddddddddddd",
                        "ddd  dd                                      dddddddddddddddd",
                        "ddd  dd                                      dddddddddddddddd",
                        "ddd                                          dddddddddddddddd",
                        "EddBWBBBBBBBBBBBBBBB  BB  BB  BB  BB  Wccccccdddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd"
    };

    string[] stage9 =  {"E             bbbdddd                                         ",
                        "  BBBBBBBBBBBwbbbdddd                                         ",
                        "  dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "  d       b      b      b      b      b      d      b     bddd",
                        "  d       b      b      b      b      d      d      d     bddd",
                        "  d      bdb    bdb    ddd    ddd    ddd    ddd    ddd    bddd",
                        "  d       b      d      b      d      d      d     ddd    bddd",
                        "E d                                                       bddd",
                        "  bbWWbbb   bbbb   bbbb   bbbb   bbbb   bbbb   bbbb   bbbwbddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddcccccdddddddddddddddddddddddddddd",
    };

    string[] stage10=   {"EE   bbb                           bddddddddd",
                         "EE   bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbbwwwccbwwwccbwwwccbwwwccbwwwbddddddddd",
                         "     dddddddddddddddddddddddddddddddddddddddd",
                         "     ddd   ddd   ddd   ddd   ddd   dddddddddd",
                         "     dddWWWdddWWWdddWWWdddWWWdddWWWdddddddddd",
                        };


    string[] stage11 = {"       d   d  　  bddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "bbbbbbbbbbbbbBBbwbdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "ddddd       bdddb dddddddddd       bdddb dddddddddd       bddddddddddddddddddd",
                        "dddddbWbwbbwbbddbWbdbdddddddbWbwbbwbdddbWbdddddddddbWbwbbwbddddddddddddddddddd",
                        "d       bdddb dddddddddd       bddddddb ddddddddddb dddddd       bb dddddddddd",
                        "dbWbwBBwbdddbWbdddddddddbWbwBBwbddddddbWddddddddddbWbdddddBBBBBBwbbWbddddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "                                                          d                   ",
                        "                                                          d                   ",
                        "                                                          dbWbbbcccccccccccccc",
                       };

    string[] stage12= { "E            dd   dd  ddd  dd    ddddddddddddddddddddddddddddddd",
                        "bbbbbbb    bbbbbbbbbbbbbbbbbb        ddddddddddddddddddddddddddd",
                        "   b                        dBb      dd    ddddddddddddddddddddd",
                        " b b b                      ddddBBBbbdd     dddddddddddddddddddd",
                        "  bbb            dd         dddddddddddd    dd   ddddddddddddddd",
                        "   b   bbbbbbbbbbbb         d    ddddddddBBbbb    dddddddddddddd",
                        "                   bbbddbbbbb    ddddddddddddd     ddddddddddddd",
                        "                                 dddddddddddddd     dddddddddddd",
                        "                                 d    d    d   d      dddddddddd",
                        "                             dbbbdbbbbbbbbbbbbbdccccccdddddddddd",
                       };

    string[] stage13 = {"E              ddd    ddd    bddddddddddddddddddddddddddddddddddddddddddd",
                        "bWWWbbbbb   bbbbbbbbbbbbbbbbwbddddddddddddddddddddddddddddddddddddddddddd",
                        "        b    ddd            dd   dd             ddd   dd       dddddddddd",
                        " d      b    ddd            dd   dd             ddd   dd       dddddddddd",
                        "  dd    bbbbbbbbbbbbbb   bbbbbbbbbbbbbbbbb   bbbbbbbbbbbbbbccccdddddddddd",
                        "                     b     dd  dd    bddbb    ddd   ddd    bddddddddddddd",
                        "                     b     dd  dd    bddbb    ddd   ddd    bddddddddddddd",
                        "                     bbbbbbbbbbbbbbbwddddbbbbbbbbbbbbbbbbbwbddddddddddddd",
                       };

    string[] stage14 ={"E                  dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbWWWbbbbb   dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbwwwbbbbb              ddd    ddd    bdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbdbbbbbbb              ddd    ddd    bdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbbddbbbbbbbbbbbbbb    bbbbbbbbbbbbbbwbdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbb    ddd              dd   dd           ddd   dd    dddd   dddd    ddd   dd   dd     dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbb    ddd              dd   dd           ddd   dd    dddd   dddd    ddd   dd   dd     dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb    bbbbbbbbbbbbbbbb    bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb    ddd  ddd   bddbb    ddd   ddd    bddddddddddddd          ddddd     dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb    ddd  ddd   bddbb    ddd   ddd    bddddddddddddd          ddddd     dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbwddddbbbbbbbbbbbbbbbbbwbdddddddddddddbWWWbbbbbbdddddcccccdddddddddd",
                       };

    string[] stage15 = {  "E            d          b     b        b         bbbdddddddddddddw",
                       "bbbbbbbb  bbbbbbBBBBbbbddbb  bbBBBBBbbbbbBBbbbbbwbbbdddddddddddddd",
                       "dddddddd  dddddd    ddddddddddd     dddddddddddddddddd            ",
                       "dddddddddddddddd    ddddddddddd     dddddddddddddddddd            ",
                       "dddddddddddddddd    ddddddddddd     ddddddddddddddddddbWcccccccccc",
                       "dddddddddddddddd    ddddddddddd     dddddddddddddddddddddddddddddd",
                       "dddddddddddddddd    dddddddddddd    dddddddddddddddddddddddddddddd",
                       "dddddddddddddddd    dddddddddddd    d   ddddd     dddddddddddddddd",
                       "dddddddddddddddddddddddddddddddd    d   ddddd     dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd  W  dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   dddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   d                         ",
                       "ddddddddddddddddddddddddddddddddd   d   d    d                    ",
                       "ddddddddddddddddddddddddddddddddd   d   d     d                   ",
                       "ddddddddddddddddddddddddddddddddd   d   d  ddddd                  ",
                       "ddddddddddddddddddddddddddddddddddddd   d     d                   ",
                       "ddddddddddddddddddddddddddddddddddddd   d    d                    ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   dddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddd                             ",
                       "dddddddddddddddddddddddddddddddddddddccccccccccccccccccccccccccccc",
                       };

    string[] stage16 ={"E            d    dd        d      d              bdddddddd",
                       "wbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "E            d    dd        d      d              bdddddddd",
                       "bbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddcccccccdddddddddddddddd",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "E            d    dd        d      d              bdddddddd",
                       "bbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "E            d    dd        d      d              bdddddddddddddddddd",
                       "bbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddddddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddd   ddddddddddd",
                       "dddddddddddddddddddddddccccccccddddddddddddddddddddddddbWbddddddddddd",
                       };

    string[] stage17 ={"E      b        b          dd    BB  b         b   dd          dd   ddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbbb    bbbbBBBBBbbbb  bbbb  bbb   BBB   bbbb  BBBBBbbdbb     dd    ddddddddddddddddddddddddddddddddddddd",
                       "         b                           b         b   BBBBBBBBBBBBBBBBBBB    ddddddddddddddddddddddddddddddddddddd",
                       "         b                           b         b     d  d  d        BBB   BBB   BBB   BBB   BBB   BBBdddddddddd",
                       "         b                           b         b    d   d   d    BBB   BBB   BBB   BBB   BBB   BBB   dddddddddd",
                       "     E   b     bbb   BB          d   b         b   d    d    d      BBB   BBB   BBB   BBB   BBB   BBBdddddddddd",
                       "bbbbbbbbbbbbbbb   bbb  bbbdBbbbbBBBbbb   BBB   bbbb BBBB BBBB bb BBB   BBB   BBB   BBB   BBB   BBB   dddddddddd",
                       "                                     b         b   d    d    d      BBB   BBB   BBB   BBB   BBB   BBBdddddddddd",
                       "                                     b         b    d   d   d    BBB   BBB   BBB   BBB   BBB   BBB   dddddddddd",
                       "                                     b         b     d  d  d        BBB   BBB   BBB   BBB   BBB   BBBdddddddddd",
                       "            E           bb     d     b         b    d   d   d    BBB   BBB   BBB   BBB   BBB   BBB   dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbb  bbbb   BBBBdBBBBBBBBBbbbbdBBBBBBBbddbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbcccccccccdddddddddd",
                       "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       };

<<<<<<< HEAD
    string[] stage18 ={ "      ddddddddWWdWWdd",
                        "      ddddddddddddddd",
                        "      ddddddddddddddd          ddddddddddd",
                        "                   dd          ddddddddddd",
                        "BBBBBBBBBBBBBBBBBBwdd          ddddddddddd",
                        "      ddddddddddddddd  B       ddddddddddd",
                        "      ddddddddddddddd   B      ddddddddddd",
                        "      ddddddddddddddd    B     ddddddddddd",
                        "                   dd     BBBBwddddddddddd",
                        "BBBBBBBBBBBBBBBBBBwdd          ddddddddddd",
                        "      ddddddddddddddd  B       ddddddddddd",
                        "      ddddddddddddddd   B      ddddddddddd",
                        "      ddddddddddddddd    B     ddddddddddd",
                        "                          BBbbwddddddddddd",
                        "BBBBBBBBBBBBBBBBBBBBBccccccccccddddddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddd" };

    /* string[] stage17 ={"        dddddddddddddddddddddddddddddddddddddddddddddddddWWWWWbbbbbcccccccccccc",
                          "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBdddddddddd",
                          "BBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBB   BBBBBdddddddddd",
                          "BB   BBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBB   BBBBB   BBBBBBBBBBBBBdddddddddd",
                          "BBBBBBBBBBBBBBB   BBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBwBBBBBBBBBBBBBBBBdddddddddd",
                          "BBBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBB   BBdddddddddd",
                          "BBBBBBBB   BBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBwBBBdddddddddd",
                          "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBB   BBBBBBBBBBdddddddddd",
                          "BBBB   BBBBBBBBB   BBBBBBB   BBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBdddddddddd",
                          "BBBBBBBBB   BBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBwBBBBBBBBBBBB   BBBBBBBBdddddddddd",
                          "BBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBdddddddddd",
                          "BBBBBB   BBBBBBBBBBBBBBBBBBBBBBBBBBBBB   BBBBBBBBBB   BBBBBBBBBBBBBBBdddddddddd",
                          "B   BBBBBBBBB   BBBBBBBBBB   BBBBBBBBBBBBBB   BBBBBBwBBBBBBBBBBBB   Bdddddddddd",
                          "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBwBBdddddddddd",
                          "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                          };
   */
    string[] stage19   ={"                   dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
=======
    string[] stage17 ={"        dddddddddddddddddddddddddddddddddddddddddddddddddWWWWWbbbbbcccccccccccc",
                       "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBdddddddddd",
                       "BBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBB   BBBBBdddddddddd",
                       "BB   BBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBB   BBBBB   BBBBBBBBBBBBBdddddddddd",
                       "BBBBBBBBBBBBBBB   BBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBwBBBBBBBBBBBBBBBBdddddddddd",
                       "BBBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBB   BBdddddddddd",
                       "BBBBBBBB   BBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBwBBBdddddddddd",
                       "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBB   BBBBBBBBBBdddddddddd",
                       "BBBB   BBBBBBBBB   BBBBBBB   BBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBdddddddddd",
                       "BBBBBBBBB   BBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBwBBBBBBBBBBBB   BBBBBBBBdddddddddd",
                       "BBBBBBBBBBBBBBBBBBBB   BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBdddddddddd",
                       "BBBBBB   BBBBBBBBBBBBBBBBBBBBBBBBBBBBB   BBBBBBBBBB   BBBBBBBBBBBBBBBdddddddddd",
                       "B   BBBBBBBBB   BBBBBBBBBB   BBBBBBBBBBBBBB   BBBBBBwBBBBBBBBBBBB   Bdddddddddd",
                       "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBwBBdddddddddd",
                       "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       };

    string[] stage18   ={"                   dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
>>>>>>> origin/Yamamotorikiya
                         "bbbbbbbbwbbbwbbbwbbdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "                   dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "                   ddddddd    ddddddddddd                  dddddd        bddddddddbbbb ",
                         "bWWbbbwbbbwbbbwbbbbbbbbbbbbWWbdddddddddddbWWbbbwbbbwbbbwbbbddddddbbbbbbbwbddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "b   b    dddddddddd    b   b    dddddddddd    b  b  b    dddddddddddddddddddddddddbbbb ",
                         "b        dddddddddd             dddddddddd               dddddddddddddddddddddddddbbbb ",
                         "bbWbbb   bbbbbbbbbbbWbbbbbbbb   bbbbbbbbbbbWbbbbbbbbbb   bddddddddddddddddddddddddbbbbW",
                         "dddddb   bddddddddddddddddddb   bddddddddddddddddddddb   bddddddddddddddddddddddddbbbb ",
                         "dddddbwwwbddddddddddddddddddbwwwbddddddddddddddddddddbwwwbddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbb ",
                         "b      ddd      ddd        dd     ddd   dd    ddd  dd     ddd  ddd   d  dd   ddd  dddd ",
                         "b      ddd      ddd        dd     ddd   dd    ddd  dd     ddd  ddd   d  dd   ddd  dddd ",
                         "bbWWWbbbbbbbbbbbbbbbbbbbbbbbbbWWWbbbbbbbbbbbbbbbbbbbbbWWWbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccccccccccccccc",
                       };

    string[] stage20  ={"E                             dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "bbbbbbbBBBbbbBBBbbbbbBBBbbb   ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd         dddddddddd",
                        "bbbbbbbBBBbbbBBBbbbbbBBBbbb   ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd         dddddddddd",
                        "bbbbbbbbbbbbbwwwbbbbbbbbbbb   ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd   WWW   dddddddddd",
                        "                          b   ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd         dddddddddd",
                        "                          b   ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd         dddddddddd",
                        "                          b   ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd         dddddddddd",
                        "                          b      ddd   ddd   ddd   ddd   ddd   d   dd   ddd  d  dd  ddd  dddd         dddddddddd",
                        "                          b         ddd   ddd   ddd   ddd      d   dd   ddd  d  dd  ddd  dddd         dddddddddd",
                        "                        E b      ddd   ddd   ddd   ddd   ddd   d   dd   ddd  d  dd  ddd  dddd         dddddddddd",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb         dddddddddd",
                        "                                                                                            b         dddddddddd",
                        "                                                                                            bcccccccccdddddddddd",
                       };

<<<<<<< HEAD
=======
    string[] stage20 = {"bbbbbb                                                     bbb   bbb        dd   ddd             ",
                        "      dd    dd                                       WWWbbb   bbb   bbbbbbbb     ",
                        "      bbbbbb                                                             ",
                        "                                                                                 ",
                        "",
                        "",
                        "",
                        "",
                        "                                                                             ddddddddddddddddddddddddddddddddd",
                        "                                                                                  dddddddddddddddddddddddddddd    ",
                        "                                                                                  dddddddddddddddddddddddddddd   ",
                        "                                                                     dd    dd     ddddddddddddd   dddddddddddd",
                        "                      ddd     ddd   ddd                  BBBBBBBBBBBBbbbbbbbb     ddddddddddddd   dddddddddddd  ",
                        "                bbbbbbbbbbbbbb                                                    dddddddddddddWWWdddddddddddd  ",
                        "                                                                             d                 ddddddddddddddddd", 
                        "                                                                                    d          ddddddddddddddddd",
                        "                                                                              d                    dddddddddddddddd",
                        "                                                                                       d              dddddddddddddddd",
                        "                                                                                                         ddddddddddddddd",
                        "",
                        "",
                        "                                         ddd                                    d                                 dddddddddddd",
                        "                                    BBBBBBBBBbbbbbwww                             dBBBBBbbbbbwwwdd                dddddddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd                dddddddddddd",
                        "                                                                                                                  dddddddddddd",
                        "                                                                                                                  dddddddddddd",
                        "                                                                                                                  dddddddddddd",
                        "                                                                                                                  dddddddddddd",
                        "                                                                                                  ccccccccccccccccccccccccccc",
                        };

>>>>>>> origin/Yamamotorikiya
    string[] stage21 ={"E       dd   BBB     bbbbbbbbbbbbbbbbb                     bbbbbbbbbb                   bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "WbbbbbbbbbbbbBBB     bbbbbbbbbbbbbbbbb                     bbbbbbbbbb                   bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbwbbbbbbbbbbbbbbbbbbb                     bbbbbbbbbb                   bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb      ddd            bbbbbbbbbb                   bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbWbbbbbdddbbbbBBB     bbbbbbbbbb                   bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbwbbbbbbbbbbbb                   bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb       dddd        bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbWbbbbbbbbbbbbb     bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbwbbbbbbbbbbbbbbwbwbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb            dddddddddddddddddddddddddddddddddddddddddd dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbWccccccccccdddddddddddddddddddddddddddddddddddddddddddWdddddddddd",
                       };

    string[] stage22 ={"E      BB                                                                       EEdddddddddddddddddddddddddddddddddd",
                       "bbbbbBBBBBBbbdd                                                                 EEE                       dddddddddd",
                       "ddddddddddddddd                                                                 EEddddWbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "            E            dd   dd                                                                          dddddddddd",
                       "           bbbbbbbbbbbBBBBBBBBBBBBBbbbbb                                                                  dddddddddd",
                       "           ddddddddddddddddddddddddddddd                                                                  dddddddddd",
                       "                                     E         dd  dd  dd                                                 dddddddddd",
                       "                                  bbbbbbbbbbbBBBBBBBBBBBBBB                                               dddddddddd",
                       "                                  ddddddddddddddddddddddddd                                               dddddddddd",
                       "                                                        E         d    d    d      d                      d    d   d",
                       "                                                     bbbbbbBBBBBBBBBBBBBBBBBBBBBBBBBBBBBbbwbbbbbbbbbbbbbbbbbbbbbbbbb",
                       "                                                     dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddbbbbbbbbb",
                       "                                                                                                                             cccccccc",
                       };

<<<<<<< HEAD
    string[] stage23 = {"bbbbbb                                                     bbb   bbb        dd   ddd             ",
                        "      dd    dd                                       WWWbbb   bbb   bbbbbbbb     ",
                        "      bbbbbb                                                             ",
                        "                                                                                 ",
                        "",
                        "",
                        "",
                        "",
                        "                                                                             ddddddddddddddddddddddddddddddddd",
                        "                                                                                  dddddddddddddddddddddddddddd",
                        "                                                                                  dddddddddddddddddddddddddddd",
                        "                                                                     dd    dd     ddddddddddddd   dddddddddddd",
                        "                      ddd     ddd   ddd                  BBBBBBBBBBBBbbbbbbbb     ddddddddddddd   dddddddddddd",
                        "                bbbbbbbbbbbbbb                                              d     dddddddddddddWWWdddddddddddd",
                        "                                                                             d     ddddddddddddddddddddddddddd",
                        "                                                                             d      dddddddddddddddddddddddddd",
                        "                                                                              d      ddddddddddddddddddddddddd",
                        "                                                                              d        ddddddddddddddddddddddd",
                        "                                                                               d       ddddddddddddddddddddddd",
                        "                                                                               d",
                        "                                                                                d",
                        "                                         ddd                                    d                                 ",
                        "                                    BBBBBBBBBbbbbbwww                            ddBBBBBbbbbbwwwdd                ",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd               ",
                        "                                                                                                                 ",
                        "                                                                                                                 ",
                        "                                                                                                                 ",
                        "                                                                                                                 ",
                        "                                                                                                   cccccccccc",
                        };
=======
    string[] stage23 ={"E                  dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbWWWbbbbb   dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbwwwbbbbb              ddd    ddd    bdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbdbbbbbbb              ddd    ddd    bdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbbddbbbbbbbbbbbbbb    bbbbbbbbbbbbbbwbdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbb    ddd              dd   dd           ddd   dd    dddd   dddd    ddd   dd   dd     dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbb    ddd              dd   dd           ddd   dd    dddd   dddd    ddd   dd   dd     dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb    bbbbbbbbbbbbbbbb    bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb    ddd  ddd   bddbb    ddd   ddd    bddddddddddddd                    dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb    ddd  ddd   bddbb    ddd   ddd    bddddddddddddd                    dddddddddd",
                       "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbwddddbbbbbbbbbbbbbbbbbwbdddddddddddddbWWWbbbbbcccccccccccdddddddddd",
                       };
>>>>>>> origin/Yamamotorikiya

    string[] stage24 = {"          dd   dd  ddd  dd   dd   dd  dd  ddddddddddddddddddddddddddddddddddddd",
                        "E         dd   dd  ddd  dd   dd   dd  dd   dd    dddddddddddddddddddddddddddddddd",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbBBBBBBBBBBBBBBBBBBd      ddddddddddddddddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddd       ddd    dddddddddddddddddddddd",
                        "                                           ddBBBBBBdddd    ddddddddddddddddddddd",
                        "                                         E dddddddddddd    dd    dddddddddddddddd",
                        "                                                dddddddBBBBdd    ddddddddddddddd",
                        "                                                dddEdddddddddd    dddddddddddddd",
                        "                                                dddddddddddddd     ddddddddddddd",
                        "                                                            ddd    dddddddddddd",
                        "                                                            ddddcccdddddddddddd",
                        };
    
    string[] stageCopy = { "" };
    void Start()
    {
        //Debug.Log(MyNum.GetOrigin());
        switch (MyNum.GetOrigin()/*stageNum*/)//stageを判別、ステージ番と同じコードのStringをStageCopyにコピペする。
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

                    case "b":   //唯のブロック
                        Instantiate(block, new Vector3(startX + j * massWidth,
                                      startY - i * massHeighth, 0.0f), Quaternion.identity);
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