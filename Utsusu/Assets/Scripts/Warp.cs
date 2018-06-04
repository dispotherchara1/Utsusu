using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour
{
    public GameObject player;
    public GameObject blockNext;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 pos = player.transform.position;
            player.transform.position = blockNext.transform.position
             + new Vector3(0.0f, 2.0f, 0.0f);
            Debug.Log("当たりました");
        }
    }
}
