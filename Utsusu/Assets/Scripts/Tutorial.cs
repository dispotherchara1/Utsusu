using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    Warp warp;
    public GameObject block, ClearZone, deathzone, neadle, warpin, warpout, BB;
    public int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount = 0, warpoutcount = 0;

    string[] tutorialstage = {
                        "bbbbbbbbbbbbbbbbbbbbbw",
                        "                      ",
                        "                      ",
                        "                      ",
                        "      d       d       ",
                        "Wbbbbbbbbbbbbbbbbbbbbw",
                        "                      ",
                        "                      ",
                        "                      ",
                        "                      ",
                        "WBBBBBBBBBBBBBBBBBBBBB",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbcccccc"

    };

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < tutorialstage.GetLength(0); i++)//stageCopyの文字数をカウントしその分だけ回す
        {
            for (int j = 0; j < tutorialstage[i].Length; j++)//横？
            {
                switch (tutorialstage[i].Substring(j, 1))
                {

                    case "b":
                        Instantiate(block, new Vector3(startX + j * massWidth,
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
                }
            }
        }
    }
}
