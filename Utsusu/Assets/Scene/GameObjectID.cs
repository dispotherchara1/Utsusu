using UnityEngine;
using System.Collections;

public class GameObjectID : MonoBehaviour {

    string ID;
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(GetInstanceID());
        
        gameObject.name = ""+GetInstanceID();
    }
}
