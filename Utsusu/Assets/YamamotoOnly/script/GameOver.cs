using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    bool Gameover = false;
	
    // Use this for initialization
	void Start (){}
	// Update is called once per frame
	void Update (){}

    public bool GetGameOver()
    {
        return Gameover;
    }

    public void SetGameOver()
    {
        Gameover = true;
    }

    public void SetGameStert()
    {
        Gameover = false;
    }
}