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
    public GameObject[] bajirisks;//バジリスクの数を好きな数だけ入れる
    public float bajirun =0.05f ;
    //public BAJI one;//物体Xに速度を突っ込むパブリック
    // Use this for initialization
    void Start () {
    
	}

    // Update is called once per frame
    void Update()
    {
        //baji_one.bajabaji;
        //baji_two.transform.position+=bajibaji();

        foreach (GameObject bajirisk in bajirisks)
        {
            //総てのバジリスクたちは進みだす
            bajirisk.transform.position += new Vector3(bajirun, 0, 0);
        }
        //one.Move(new Vector3(0.2f, 0, 0));//物体Xの速さはx軸に+0.2/
    }

   /*Vector3 bajibaji()
    {
        return 
            transform.position += new Vector3(0.7f, 0, 0);
        ;
    }*/
}
