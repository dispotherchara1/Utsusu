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
    GameOver gameover;
    float bajirun = 0.2f ;
    bool bajicall = false;
    void Start () {
    
	}

    // Update is called once per frame
    void Update() {
        //{
        //    baji_one.bajabaji;
        //    baji_two.transform.position += bajibaji();
        if (bajicall==true)
        {
            //        foreach (GameObject bajirisk in bajirisks)
            //        {
            //総てのバジリスクたちは進みだす

            gameObject.transform.position += new Vector3(bajirun, 0, 0);
        }
        //    }
        //}
        //one.Move(new Vector3(0.2f, 0, 0));//物体Xの速さはx軸に+0.2/
    }

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
            bajicall = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            baji = GameObject.Find("bajirisk" + (gameObject.name));
            bajicall = true;
        }
    }
    public void misscalling()
    {
        bajicall = false;
    }
    //public void OKcalling()
    //{
    //    bajicall = false;
    //}
}
