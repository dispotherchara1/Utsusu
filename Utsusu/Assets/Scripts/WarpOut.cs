using UnityEngine;
using System.Collections;

public class WarpOut : MonoBehaviour
{
    public int warpOutCount = 0;

    void Start()
    {
        if (gameObject)
        {
            warpOutCount++;
        }
    }
    

}
