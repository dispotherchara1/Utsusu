using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    bool Gameover = false,Clear=false;
	

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


    public bool GetClear()
    {
        return Clear;
    }

    public void SetClear()
    {
        Clear = true;
    }

    public void ReSetClear()
    {
        Clear = false;
    }



}