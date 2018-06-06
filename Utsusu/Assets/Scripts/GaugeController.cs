using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public GameOver gameover;
    Slider gaugeSlider;
    bool gauge = false;
    float timeCount = 0.0f;
    const float MAXVALUE = 1.0f;
    const float MOVE = 20.0f;

    public bool GetGauge()
    {
        return gauge;
    }

    public float GetTime()
    {
        return timeCount * MOVE;
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
    void Update()
    {
        if (gameover.GetGameOver() == false && gameover.GetClear() == false)
        {
            //スペースボタンを押している間ゲージがtrue(ゲージが動く)
            if (Input.GetKey(KeyCode.Space))
            {
                gauge = true;
            }
            else
            {
                gauge = false;//押してないときfalse
            }

            if (gauge)
            {
                timeCount += Time.deltaTime;
                if (timeCount >= MAXVALUE)//ゲージの最大値
                {
                    timeCount = 0.0f;//ゼロに戻る
                }
            }
            gaugeSlider.value = timeCount;
        }
    }
}
