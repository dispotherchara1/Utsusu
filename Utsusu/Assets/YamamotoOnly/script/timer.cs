using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public Text time;
    float timecounter=30;
    public GameOver gameover;
	// Use this for initialization
	void Start (){}
	// Update is called once per frame
	void Update (){
        time.text = timecounter.ToString("F0");
        if (gameover.GetClear()==false&&gameover.GetGameOver()==false&&timecounter>=0)
        { Encounttimer(-Time.deltaTime); }
	}

    public void Encounttimer(float timer)
    {

        //if (timecounter >= 0 && gameover.GetGameOver() == false)
            timecounter += timer;
        if (timecounter<=0) { gameover.SetGameOver(); }
    }

}