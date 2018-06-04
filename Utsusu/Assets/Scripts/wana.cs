using UnityEngine;
using System.Collections;

public class wana : MonoBehaviour
{
    public Transform target;//追いかける対象-オブジェクトをインスペクタから登録できるように
    public float speed = 0.1f;//移動スピード
    bool hit = false;
    private Vector3 vec;

    //オブジェクトが衝突したとき
    void OnTriggerEnter2D(Collider2D other)
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
    void Start()
    {
        //target = GameObject.Find("対象").transform; インスペクタから登録するのでいらない
    }

    void Update()
    {
        //targetの方に少しずつ向きが変わる
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);

        //targetに向かって進む
        transform.position += transform.forward * speed;

        if (hit)
        {
            Debug.Log("当たりました");
        }
        else
        {
            Debug.Log("当たっていません");
        }
    }
}