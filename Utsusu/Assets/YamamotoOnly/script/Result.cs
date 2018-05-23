using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

    public GameOver gameover;
    public Button continued,back,olga;
    public Image[] button;
    public Text[] nyan; 
    //public Scene Scene; 
	// Use this for initialization
	public void Start ()
    {
        back.enabled = false;continued.enabled = false;olga.enabled = false;
        button[0].enabled = false; button[1].enabled = false; button[2].enabled = false;
        nyan[0].enabled = false; nyan[1].enabled = false; nyan[2].enabled = false;
    }
    // Update is called once per frame
    public void Update (){
        if (gameover.GetGameOver() == true)
        {
            back.enabled = true; continued.enabled = true; olga.enabled = true;
            button[0].enabled = true; button[1].enabled = true; button[2].enabled = true;
            nyan[0].enabled = true; nyan[1].enabled = true; nyan[2].enabled = true;
        }
    }
    public void totitle()
    {
        SceneManager.LoadScene("title");
        gameover.SetGameStert();
    }
    public void Restartgame()
    {
        gameover.SetGameStert();
    }
}
