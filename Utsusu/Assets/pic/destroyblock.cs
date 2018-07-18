using UnityEngine;
using System.Collections;

public class destroyblock : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject,1f);
        }
    }
}