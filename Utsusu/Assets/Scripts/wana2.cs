using UnityEngine;
using System.Collections;

public class wana2 : MonoBehaviour
{
    public Transform target;//追いかける対象-オブジェクトをインスペクタから登録できるように
    public float speed = 0.1f;//移動スピード
    bool hit = false;
    private Vector3 vec;

    public bool GetHit()
    {
        return hit;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("範囲に入りました");//targetに向かって進む
            hit = true;
        }
        else
        {
            hit = false;
        }
    }
}