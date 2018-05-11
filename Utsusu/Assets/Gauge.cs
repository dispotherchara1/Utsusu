﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    Slider gaugeSlider;
    bool gauge = false;
    float timeCount = 0.0f;
    /*
    public float GetTimeCount()
    {
        return timeCount;
    }*/

    public void GetTimeCount(float setTime)
    {
        getTime = timeCount;
    }
    // Use this for initialization
    void Start()
    {
        gaugeSlider = GameObject.Find("Slider").GetComponent<Slider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.B))//Bボタンを押している間ゲージがtrue(ゲージが動く)
        {
            gauge = true;
        }
        else
        {
            gauge = false;//押してないときfalse
        }

        if (gauge)
        {
            timeCount += 3 * Time.deltaTime;
            if (timeCount >= 5.0f)//ゲージの最大値
            {
                timeCount = 0.0f;//ゼロに戻る
            }
        }
        else      //Bボタンを離したときplayerが動く
        {
            Debug.Log(timeCount);
            timeCount = 0.0f;                                 //falseに戻したときに初期化する
        }
        gaugeSlider.value = timeCount;
    }
}
