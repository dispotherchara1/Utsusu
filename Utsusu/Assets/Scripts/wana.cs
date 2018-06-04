using UnityEngine;
using System.Collections;

public class wana : MonoBehaviour
{
    public Transform target;//追いかける対象-オブジェクトをインスペクタから登録できるように
    public float speed = 0.1f;//移動スピード
    private Vector3 vec;
    public wana2 wana2;

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("プレイヤーに当たりました");
    }


    void Update()
    {
        if (wana2.GetHit())
        {             //targetの方に少しずつ向きが変わる
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation
                (target.position - transform.position), 0.3f);

            //targetに向かって進む
            transform.position += transform.forward * speed;
        }
        //transform.Rotate(0.0f, 0.0f, 0.0f);
    }
}