using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    //ゲームオーバーか、ゲームクリアーかどうかのBool変数
    bool Gameover = false,Clear=false;


    public bool GetGameOver()//ゲームオーバーかどうかを調べます
    {
        return Gameover;
    }

    public void SetGameOver()//ゲームオーバーをオンにします
    {
        Gameover = true;
    }

    public void SetGameStert()//ゲームボーバーをオフにします
    {
        Gameover = false;
    }


    public bool GetClear()//ゲームクリアーしたかどうか調べます
    {
        return Clear;
    }

    public void SetClear()//ゲームクリアーをオンにします
    {
        Clear = true;
    }

    public void ReSetClear()//ゲームクリアーをオフにします
    {
        Clear = false;
    }
}