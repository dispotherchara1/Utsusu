using UnityEngine;
using System.Collections;

public class stagecriateTest : MonoBehaviour {
    Loadingnow loading;
    public GameObject block,Clearzone;
    public int startX=3, startY=3, massWidth=3, massHeighth=3;
    string[] stage_one = {
                        " b b  bb  b     bb       bb        b",
                        "b    b   b  b       bb             b",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbcccccccccc" };
    string[] stage_tow = {
                        " b b  bb",
                        "b    b   b  b ",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbcccccccccc" };


    void Start()
    {
        for (int i = 0; i < stage_one.GetLength(0); i++)
        {
            for (int j = 0; j < stage_one[i].Length; j++)
            {
                switch (loading.Getload())
                {
                    case 0:
                       
                        if (stage_one[i].Substring(j, 1) == "b")
                        {
                            Instantiate(block, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                        }
                        if (stage_one[i].Substring(j, 1) == "c")
                        {
                            Instantiate(Clearzone, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                        }
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
        }
}