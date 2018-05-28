using UnityEngine;
using System.Collections;

public class stagecriateTest : MonoBehaviour {
    public GameObject block;
    public int startX=3, startY=3, massWidth=3, massHeighth=3;
    string[] stage = {
                        "b    bb   b",
                        "bbbbbbbbbbb" };

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
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}