using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour
{
    string[] warpNum    = { "warpBlock0", "warpBlock1", "warpBlock2", "warpBlock3" };
    string[] warpOutNum = { "warpoutBlockwarpBlock0", "warpoutBlockwarpBlock1",
                            "warpoutBlockwarpBlock2", "warpoutBlockwarpBlock3" };
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            //このwarpBlockが生成された時点ではwarpoutが生成されていない可能性があるので
            //この中に入れておきます
            GameObject warpout =GameObject.Find("warpoutBlock" + (gameObject.name));
            //Vector3 pos = player.transform.position;
            switch (stagecriate.RequestStageNum())//stageを判別
            { 
                case 12:
                    if (gameObject.name == warpNum[0])
                    {
                        warpout = GameObject.Find(warpOutNum[2]);
                    }
                    if (gameObject.name == warpNum[1])
                    {
                        warpout = GameObject.Find(warpOutNum[3]);
                    }
                    if (gameObject.name == warpNum[2])
                    {
                        warpout = GameObject.Find(warpOutNum[0]);
                    }
                    if (gameObject.name == warpNum[3])
                    {
                        warpout = GameObject.Find(warpOutNum[1]);
                    }
                    break;
            }
            //他のgameobjectがこのgameobjectと当たって、そのgameobjectのタグがPlayerだった場合
            //otherとし条件式に当てはめ、位置を与える.
            other.gameObject.transform.position = warpout.transform.position
            + new Vector3(0.0f, 2.0f, 0.0f);

            //↓対応させました
            /*現在このコードは複数のワープエリアに対応しておりません。
            入口が複数あり出口がひとつというパターンは対応されています。*/    
        } 
    }
}
