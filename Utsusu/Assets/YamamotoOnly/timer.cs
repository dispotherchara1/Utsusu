using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public Text time;
    bool timeover = false;
    float timecounter=30;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time.text = timecounter.ToString("F0");
        if (timecounter>=0) { Encounttimer(-Time.deltaTime); }

        if (timeover == true) { Debug.Log("trueになっちゃったよ"); }
	}

    public void Encounttimer (float timer){

        if (timecounter>=0)
        {
            timecounter+=timer;
        }

        else { timeover = true; }
        }


}
