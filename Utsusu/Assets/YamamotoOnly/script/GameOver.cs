using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    //ゲームオーバーか、ゲームクリアーかどうかのBool変数
    public bajirisk baji;
    public SceneChange MyNum;
    bool Gameover = false, Clear = false;
    public Canvas GameOverCv,ClearButton,turncv;
    public Image Clearimg, GameOverimg;
    private void Start()
    {
        GameOverCv.enabled = false;
        Clearimg.enabled = false;
        GameOverimg.enabled = false;
        ClearButton.enabled = false;
        turncv.enabled = false;
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
        if (MyNum.GetOrigin() > 1)
        {
            turncv.enabled = true;
        }
    }
    public bool GetClear()//ゲームクリアーしたかどうか調べます
    {
        return Clear;
    }
    public void SetClear()//ゲームクリアーをオンにします
    {
        Clear = true;
        if (MyNum.GetOrigin()!=24) { ClearButton.enabled = true; }
        if (MyNum.GetOrigin() > 1) { turncv.enabled = true; }
        GameOverCv.enabled = true;
        Clearimg.enabled = true;
        }
}