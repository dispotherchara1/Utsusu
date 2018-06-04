using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Re_sult : MonoBehaviour {
    
    public void turn()
    {
        SceneManager.LoadScene("title");
    }

    public void reload()
    {
        SceneManager.LoadScene(1); // シーン読み込みの際に破棄されなくなる
    }
}
