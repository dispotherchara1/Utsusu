using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Honjo()
    {
        SceneManager.LoadScene("honjo");
    }

    public void Select()
    {
        SceneManager.LoadScene("select");
    }

    public void Title()
    {
        SceneManager.LoadScene("title");
    }
}
