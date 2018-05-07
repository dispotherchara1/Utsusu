using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    Vector2 teleportation = new Vector2(50.0f, 0.0f);
    // Use this for initialization
    void Start ()
    {
    }

    // Update is called once per frame
    void Update ()
    {
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
        transform.position = pos ;//現在の位置にteleportationの移動距離を加算
    }
}
