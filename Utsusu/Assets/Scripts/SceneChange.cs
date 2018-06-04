using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    stagecriate stagecriate;//LoadScene(4)はゲームシーンに飛ぶよ。

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
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(1);
    }

    public void Stage2()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(2);
    }

    public void Stage3()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(3);
    }

    public void Stage4()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(4);
    }

    public void Stage5()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(5);
    }

    public void Stage6()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(6);
    }

    public void Stage7()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(7);
    }

    public void Stage8()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(8);
    }

}
