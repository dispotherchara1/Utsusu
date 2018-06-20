using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    SelectText selectText;
    stagecriate stagecriate;//LoadScene(4)はゲームシーンに飛ぶよ。
    
    public void Select()
    {
        SceneManager.LoadScene("select");
    }

    public void Title()
    {
        SceneManager.LoadScene("title");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(5);
    }

    public void Stage()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(1 + SelectText.GetSelectNum());
        selectText.SetSelectNum(1);
    }

    public void Stage2()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(2 + SelectText.GetSelectNum());
    }

    public void Stage3()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(3 + SelectText.GetSelectNum());
    }

    public void Stage4()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(4 + SelectText.GetSelectNum());
    }

    public void Stage5()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(5 + SelectText.GetSelectNum());
    }

    public void Stage6()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(6 + SelectText.GetSelectNum());
    }
    
    public void Stage7()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(7 + SelectText.GetSelectNum());
    }

    public void Stage8()
    {
        SceneManager.LoadScene(4);
        stagecriate.GetStageNum(8 + SelectText.GetSelectNum());
    }
}
