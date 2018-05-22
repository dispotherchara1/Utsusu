using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {
    public GameOver gameover;
    //public Scene Scene; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void totitle()
    {
        SceneManager.LoadScene("title");
        gameover.SetGameStert();
    }
    void Restartgame()
    {
        gameover.SetGameStert();
    }
}
