using UnityEngine;
using System.Collections;

//public class BAJI //
//{
//    public GameObject obj;//ここに物体Xを突っ込む
//    public void Move(Vector3 move)
//    {
//        obj.transform.position += move;//物体は加速する
//    }
//}

public class bajirisk : MonoBehaviour {
    GameObject baji;//バジリスクの数を好きな数だけ入れる
    float bajirun =0.4f ;
    void Start () {
    
	}

    // Update is called once per frame
    //void Update()
    //{
    //    //baji_one.bajabaji;
    //    //baji_two.transform.position+=bajibaji();
    //    //if (gameover.GetGameOver() == false && gameover.GetClear() == false)
    //    //{
    //    //    foreach (GameObject bajirisk in bajirisks)
    //    //    {
    //    //        //総てのバジリスクたちは進みだす
    //    //        bajirisk.transform.position += new Vector3(bajirun, 0, 0);
    //    //    }
    //    //}
    //    //one.Move(new Vector3(0.2f, 0, 0));//物体Xの速さはx軸に+0.2/
    //}

    /*Vector3 bajibaji()
     {
         return 
             transform.position += new Vector3(0.7f, 0, 0);
         ;
     }*/
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log(col.gameObject.tag);←このコードで「なんのタグとぶつかったか？」が検出される.
            //ArrayList j = new ArrayList();
            //このbajiriskが生成された時点ではbajiriskが生成されていない可能性があるので
            //この中に入れておきます
            baji = GameObject.Find("bajirisk" + (gameObject.name));
            //Vector3 pos = player.transform.position;
            //バジリスクは進みだす
            baji.transform.position += new Vector3(/*bajirun*/5, 0, 0) * Time.deltaTime;
        }
    }
}
