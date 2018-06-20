using UnityEngine;
using System.Collections;

public class player_tel : MonoBehaviour
{
    public Transform player;
    public GaugeController guageController;
    Vector2 teleportation = new Vector2(50.0f, 0.0f);
    Vector2 pos_player = new Vector2(0.0f, 0.0f);
    // Update is called once per frame
    void Update()
    {
        pos_player = player.position;
        //移動計算式
        pos_player += teleportation * guageController.GetTime() * Time.deltaTime;
        transform.position = pos_player;
    }
}
