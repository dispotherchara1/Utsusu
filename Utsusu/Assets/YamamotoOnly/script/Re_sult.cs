using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Re_sult : MonoBehaviour {

    int a = stagecriate.RequestStageNum();
    public void turn()
    {
        SceneManager.LoadScene(3);//titleシーンに戻る
    }

    public void reload()
    {
        SceneManager.LoadScene(4);//GameSceneシーンを再度呼び込む
    }
    public void backstage()
    {
        if (a > 1) {
            SceneManager.LoadScene(4);
            a--;
            stagecriate.GetStageNum(a);
        }
    }
    public void nextstage()
    {
        if (a < 8)
        {
            SceneManager.LoadScene(4);
            a++;
            stagecriate.GetStageNum(a);
        }
    }
}
