using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
    bool Muteki = false;
	public bool getitem()
    {
        return Muteki;
    }
    //public void Setitem()
    //{
    //    Muteki = true;
    //}
    public void Outitem()
    {
        Muteki = false;
    }
    private void OnColliderEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") { Muteki = true; }
        Debug.Log("でば☆ろぐ");
        Destroy(gameObject);
    }
}
