using UnityEngine;
using System.Collections;

public class wana2 : MonoBehaviour
{
    //public Transform target;//追いかける対象-オブジェクトをインスペクタから登録できるように
    bool hit = false;

    public bool GetHit()
    {
        return hit;
    }

    //オブジェクトが衝突したとき
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            hit = true;
        }
        else 
        {
            hit = false;
        }
    }

    void Update()
    {
    //    if (hit)
    //    {
    //        Debug.Log("当たりました");
    //    }
    //    else
    //    {
    //        Debug.Log("当たっていません");
    //    }
    }
}