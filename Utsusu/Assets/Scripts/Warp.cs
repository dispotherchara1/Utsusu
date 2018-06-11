using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour
{
    //GameObject player = GameObject.Find("Player");
    public int warpNo;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            //このwarpBlockが生成された時点ではwarpoutが生成されていない可能性があるので
            //この中に入れておきます
            GameObject warpout =GameObject.Find("warpoutBlock"+(gameObject.name));
            //Vector3 pos = player.transform.position;
            
            //他のgameobjectがこのgameobjectと当たって、そのgameobjectのタグがPlayerだった場合
            //otherとし条件式に当てはめ、位置を与える.
            other.gameObject.transform.position = warpout.transform.position
            + new Vector3(0.0f, 2.0f, 0.0f);
            
            //↓対応させました
            /*現在このコードは複数のワープエリアに対応しておりません。
            入口が複数あり出口がひとつというパターンは対応されています。*/
        } 
    }
    public void setwarpNo(int a)
    {
        warpNo = a;
    }
}
