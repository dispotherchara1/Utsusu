using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Re_sult : MonoBehaviour {

    int stageclear = 0;
    int Stagenum = stagecriate.RequestStageNum();
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
        if (Stagenum > 1) {
            SceneManager.LoadScene(4);
            Stagenum--;
            stagecriate.GetStageNum(Stagenum);
        }
    }
    public void nextstage()
    {
        if (Stagenum < 8)
        {
            SceneManager.LoadScene(4);
            Stagenum++;
            stagecriate.GetStageNum(Stagenum);
        }
    }
}
