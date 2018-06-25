using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public GameOver gameover;
    Slider gaugeSlider;
    bool gauge = false;
    bool particle = false;
    float timeCount = 0.0f;
    float particleCount = 0.2f;
    const float MAXVALUE = 2.0f;
    const float MOVE = 11.5f;

    public bool GetParticle()
    {
        return particle;
    }

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
                particleCount = 0.0f;//リセット
            }
            else
            {
                gauge = false;//押してないときfalse
                //trueになってパーティクルを呼び、falseにする
                //particleCountが0になるとパーティクルシステムが作動
                if (particleCount < 0.01f)
                {
                    particle = true;
                    particleCount = 2;
                }
                else
                {
                    //particleがfalseでもパーティクルシステムは作動しないようになっているので
                    //ここに計算式を描く必要はない。
                    particle = false;
                }
            }

            if (gauge)
            {
                timeCount += (.9f * Time.deltaTime)+.05f;//*Time.deltaTime;
                if (timeCount >= MAXVALUE)//ゲージの最大値
                {
                    timeCount = 0.0f;//ゼロに戻る
                }
            }
            gaugeSlider.value = timeCount;
        }
    }
}
