using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {
    
    public GameOver gameover;
	
    // Use this for initialization
	void Start (){}	
	// Update is called once per frame
	void Update (){
        if (gameover.GetGameOver() == true) { Debug.Log("GameOver"); }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DeathZone")
        {
            gameover.SetGameOver();
        }
    }
}
