using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour {
    
    public Text printer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        printer.text = clicker.page.ToString("F0");
    }
}
