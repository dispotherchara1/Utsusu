using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Re_sult : MonoBehaviour {
    
    public void turn()
    {
        SceneManager.LoadScene(3);//titleシーンに戻る
    }

    public void reload()
    {
        SceneManager.LoadScene(4);//GameSceneシーンを再度呼び込む
    }
}
