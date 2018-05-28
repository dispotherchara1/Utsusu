using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    stagecriate stagecriate;
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

    public void Stage()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(1);
    }

    public void Stage2()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(2);
    }

    public void Stage3()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(3);
    }

    public void Stage4()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(4);
    }

    public void Stage5()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(5);
    }

    public void Stage6()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(6);
    }

    public void Stage7()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(7);
    }

    public void Stage8()
    {
        SceneManager.LoadScene("honjo");
        stagecriate.GetStageNum(8);
    }


}
