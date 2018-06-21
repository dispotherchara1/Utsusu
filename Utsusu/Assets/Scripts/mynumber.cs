using UnityEngine;
using System.Collections;

public class mynumber : MonoBehaviour {
    public static int stageNum=0;

    public int GetstageNum()
    {
        return stageNum;
    }

    public void SetstageNum(int a)
    {
        stageNum = a;
    }
}
