using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Re_sult : MonoBehaviour {
    public SceneChange MyNum;   //SceneChangeをMynumという名で使用。主にステージのナンバー
    //int stageclear = 0;       //なんぞこれ
    int Stagenum;               //今なんステージ？
    private void Start()
    {
        Stagenum = MyNum.GetOrigin();
       // Debug.Log(Stagenum);
    }
    public void turn()
    {
        SceneManager.LoadScene(0);  //titleシーンに戻る
        MyNum.SetOrigin(0);         //
    }

    public void reload()
    {// 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }

    public void backstage()
    {//カウントが１以上なら前のステージに戻れる
        if (Stagenum > 1) {
            Stagenum--;
            MyNum.SetOrigin(Stagenum);
            SceneManager.LoadScene(2);
        }
    }

    public void nextstage()
    {//〃２４以内なら次ステージに行ける。
        if (Stagenum < 24)
        {
            //MyNum.Setflg(Stagenum);
            Stagenum++;
            MyNum.SetOrigin(Stagenum);
            SceneManager.LoadScene(2);
        }
    }
}