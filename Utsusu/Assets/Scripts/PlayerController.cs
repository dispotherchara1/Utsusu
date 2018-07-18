using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    public item Item;
    public GameOver gameover;
    public GaugeController gaugeController;
    Vector2 teleportation = new Vector2(75.0f, 0.0f);
    private const float gravitationalAcceleration = -9.81f;
    public AudioSource[] sources;
    Collision2D it;
    public Collider2D test;
    /// <summary>
    /// 重力方向を変更する.
    /// </summary>
    /// <param name="direction">重力の向き.</param>
    private void Change(Vector2 direction)
    {
        //引数のVecotr2を単位ベクトルに正規化し重力加速度を掛ける.
        Physics2D.gravity = direction.normalized * gravitationalAcceleration;
        //Debug.Log(Physics2D.gravity);
    }
    void Update()
    {
        if (!gameover.GetGameOver() && !gameover.GetClear())
        {
           //Button();//ボタンで移動距離が変わるメソッド
            GoGauge();//ゲージ式
            if (gaugeController.GetParticle())
            {
                //パーティクルシステムが発動
                GetComponent<ParticleSystem>().Play();//パーティクル
                sources[0].Play();//音
            }
        }
    }
    //AwakeはStartが実行される前に初期重力を設定する(Startないけど)
    void Awake()
    {
        //sources = gameObject.GetComponents<AudioSource>();
        Physics2D.gravity = Vector3.up * gravitationalAcceleration;
    }

    void Button() // ボタンで移動距離が違う
    {
        Vector2 pos = transform.position;  // 現在位置をposに代入

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
        transform.position = pos; //現在の位置にteleportationの移動距離を加算
    }

    void GoGauge()
    {
        Vector2 pos = transform.position; //現在位置をposに代入

        if (!gaugeController.GetGauge())
        {
            //移動計算式
            pos += teleportation * gaugeController.GetTime() * Time.deltaTime;
            gaugeController.GetResetTime();
        }
        transform.position = pos; //現在の位置にteleportationの移動距離を加算

        //if (test.gameObject.tag == "DeathZone"&&Item.getitem()) { Item.Outitem(); }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!gameover.GetGameOver() && col.gameObject.tag == "ClearZone")
        {
            gameover.SetClear();
        }
        if (!gameover.GetClear() && col.gameObject.tag == "DeathZone" && !Item.getitem())
        {
            gameover.SetGameOver();
        }
    }
}