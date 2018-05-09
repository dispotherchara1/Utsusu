using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    Vector2 teleportation = new Vector2(50.0f, 0.0f);
    bool gauge = false;
    float timeCount = 0.0f;
    // Use this for initialization
    void Start ()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        Vector2 pos = transform.position;// 現在位置をposに代入

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
            //Debug.Log("timeCont " + timeCount);
        }
        else      //Bボタンを離したときplayerが動く
        {
            pos += teleportation * timeCount * Time.deltaTime;//移動計算式
            timeCount = 0.0f;                                 //falseに戻したときに初期化する
        }
        //Debug.Log("gauge " + gauge);
        //Debug.Log("timeCont " + timeCount);

        transform.position = pos;//現在の位置にteleportationの移動距離を加算
        /*
        Vector2 pos = transform.position;// 現在位置をposに代入

        if (Input.GetKeyDown(KeyCode.B))
        {
            pos += teleportation * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            pos += teleportation * 2 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            pos += teleportation * 3 * Time.deltaTime;
        }
        transform.position = pos;//現在の位置にteleportationの移動距離を加算
        */
    }
}
