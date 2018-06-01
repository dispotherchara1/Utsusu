using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class stagecriate : MonoBehaviour {

    public GameObject block,ClearZone,deathzone;

=======
public class stagecriate : MonoBehaviour
{
    public GameObject block;
>>>>>>> origin/honjo
    public int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;

    static int stageNum = 1;

    string[] stage1 = {
                        "b          ",
                        "bbbbbbbbbbbccccc" };
    string[] stage2 = {
                        " b         ",
                        "bbbbbbbbbbb" };
    string[] stage3 = {
                        "  b        ",
                        "bbbbbbbbbbb" };
    string[] stage4 = {
                        "   bbb     ",
                        "bbbbbbbbbbb" };
    string[] stage5 = {
                        "   bbb     ",
                        "bbbbbbbbbbb" };
    string[] stage6 = {
                        "     bbbbbb",
                        "bbbbbbbbbbb" };
    string[] stage7 = {
                        "      bbbbb",
                        "bbbbbbbbbbb" };
    string[] stage8 = {
                        "       bbbb",
                        "bbbbbbbbbbb" };

    string[] stageCopy ={""};

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
                if (stageCopy[i].Substring(j, 1) == "b")
                {
                    Instantiate(block, new Vector3(startX + j * massWidth, 
                    startY - i * massHeighth, 0.0f), Quaternion.identity);
                }
                if (stageCopy[i].Substring(j, 1) == "c")
                {
                    Instantiate(ClearZone, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                }
            }
        }
    }
<<<<<<< HEAD
    public static void GetStageNum(int a)//staticをつけてシーンを移動しても保存できる
    {
        stageNum = a;
    }
=======

>>>>>>> origin/honjo
}