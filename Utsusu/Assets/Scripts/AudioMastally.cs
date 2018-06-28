using UnityEngine;
using System.Collections;

public class AudioMastally : MonoBehaviour {

    public AudioSource[] sources;
    // Use this for initialization
    void Start () {
        sources[0].Play();//音1
        //sources[1].Play();//音2
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
