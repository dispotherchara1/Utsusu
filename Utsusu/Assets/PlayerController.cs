using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    Gauge gauge;
    Vector2 teleportation = new Vector2(50.0f, 0.0f);
    float gettime = 0.0f;

    // Update is called once per frame
    void Update ()
    {
        Vector2 pos = transform.position;                            // 現在位置をposに代入
        //if(gauge.GetTimeCount() != 0.0f)
        {
           // pos += teleportation * gauge.GetTimeCount(gettime) * Time.deltaTime;//移動計算式
        }
        transform.position = pos;                           //現在の位置にteleportationの移動距離を加算

        /*ボタンで移動距離が違う
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
