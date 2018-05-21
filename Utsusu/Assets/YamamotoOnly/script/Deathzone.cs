using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.tag = "DeathZone";
    }
}
