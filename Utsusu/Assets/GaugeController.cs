using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    Slider gaugeSlider;
    bool gauge = false;
    float timeCount = 0.0f;
    const float MAXVALUE = 10.0f;
    const float GAUGESPEED = 10.0f;

    public bool GetGauge()
    {
        return gauge;
    }

    public float GetTime()
    {
        return timeCount;
    }

    public void GetResetTime()//timeCountをリセット
    {
        timeCount = 0.0f;
    }

    // Use this for initialization
    void Start()
    {
        gaugeSlider = GameObject.Find("Slider").GetComponent<Slider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))//Bボタンを押している間ゲージがtrue(ゲージが動く)
        {
            gauge = true;
        }
        else
        {
            gauge = false;//押してないときfalse
        }

        if (gauge)
        {
            timeCount += GAUGESPEED * Time.deltaTime;
            if (timeCount >= MAXVALUE)//ゲージの最大値
            {
                timeCount = 0.0f;//ゼロに戻る
            }
        }
        gaugeSlider.value = timeCount;
    }
}
