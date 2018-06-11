using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    //ゲームオーバーか、ゲームクリアーかどうかのBool変数
    bool Gameover = false, Clear = false;
    public Canvas GameOverCv,ClearButton;
    public Image Clearimg, GameOverimg;
    private void Start()
    {
        GameOverCv.enabled = false;
        Clearimg.enabled = false;
        GameOverimg.enabled = false;
        ClearButton.enabled = false;
    }
    //////////////////////////////////////////////////////////////////////

    public bool GetGameOver()//ゲームオーバーかどうかを調べます
    {
        return Gameover;
    }

    public void SetGameOver()//ゲームオーバーをオンにします
    {
        Gameover = true;
        GameOverCv.enabled = true;
        GameOverimg.enabled = true;
    }
    public bool GetClear()//ゲームクリアーしたかどうか調べます
    {
        return Clear;
    }
    public void SetClear()//ゲームクリアーをオンにします
    {
        Clear = true;
        GameOverCv.enabled = true;
        ClearButton.enabled = true;
        Clearimg.enabled = true;
    }
}