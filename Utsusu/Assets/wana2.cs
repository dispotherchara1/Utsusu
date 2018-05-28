﻿using UnityEngine;
using System.Collections;

public class wana2 : MonoBehaviour
{
    public Transform target;//追いかける対象-オブジェクトをインスペクタから登録できるように
    public float speed = 0.1f;//移動スピード
    private Vector3 vec;

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Cube(2)")
        {
            Destroy(other.gameObject); 
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
    }
}