using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clicker : MonoBehaviour {

    bool click = true;
    public Text print;
    float page;
	
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) { printer(+1);}
        print.text =page.ToString("F0");
	}

    public void printer (float printed)
    {
        page += printed; 
    }

}
