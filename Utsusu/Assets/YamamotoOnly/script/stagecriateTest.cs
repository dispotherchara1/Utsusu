using UnityEngine;
using System.Collections;

public class stagecriateTest : MonoBehaviour {
    public GameObject block,Clearzone;
    public int startX=3, startY=3, massWidth=3, massHeighth=3;
    string[] stage = {" b b  bb",
                        "b    b   b  b",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbcccccccccc" };

    void Start()
    {
        for (int i = 0; i < stage.GetLength(0); i++)
        {
            for (int j = 0; j < stage[i].Length; j++)
            {
                if (stage[i].Substring(j, 1) == "b")
                {
                    Instantiate(block, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                }
                if (stage[i].Substring(j, 1) == "c")
                {
                    Instantiate(Clearzone, new Vector3(startX + j * massWidth, startY - i * massHeighth, 0.0f), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}