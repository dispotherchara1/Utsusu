using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    //ゲームオーバーか、ゲームクリアーかどうかのBool変数
    bool Gameover = false, Clear = false;
    public Canvas gameobera;
    public Image Clearimg, GameOverimg;
    private void Start()
    {
<<<<<<< HEAD
        gameobera.enabled = false;
        Clearimg.enabled = false;
        GameOverimg.enabled = false;
=======
        //gameobera.enabled = false;
>>>>>>> origin/honjo
    }
    private void Update()
    {
        if (Gameover == true||Clear==true)
        {
            gameobera.enabled = true;
        }
    }
    //////////////////////////////////////////////////////////////////////

    public bool GetGameOver()//ゲームオーバーかどうかを調べます
    {
        return Gameover;
    }

    public void SetGameOver()//ゲームオーバーをオンにします
    {
        Gameover = true;
        GameOverimg.enabled = true;
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
        Clearimg.enabled = true;
    }

    public void ReSetClear()//ゲームクリアーをオフにします
    {
        Clear = false;
    }
}