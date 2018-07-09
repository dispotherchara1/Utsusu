using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    stagecriate stagecriate;//LoadScene(4)はゲームシーンに飛ぶよ。
    int selectNum = 1;
    static int StageofOrigen = 0;
    public void Title()
    {
        SceneManager.LoadScene(0);//セレクトを再読み込み
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(5);
    }

    public void Stage()
    {
        SceneManager.LoadScene(4);
        StageofOrigen+=(selectNum + 1);
    }

    public void Stage2()
    {
        SceneManager.LoadScene(4);
        StageofOrigen += +(selectNum + 2);
    }

    public void Stage3()
    {
        SceneManager.LoadScene(4);
        StageofOrigen += (selectNum + 3);
    }

    public void Stage4()
    {
        SceneManager.LoadScene(4);
        StageofOrigen += (selectNum + 4);
    }

    public void Stage5()
    {
       SceneManager.LoadScene(4);
        StageofOrigen += (selectNum + 5);
    }

    public void Stage6()
    {
        SceneManager.LoadScene(4);
        StageofOrigen += (selectNum + 6);
    }

    public void Stage7()
    {
        SceneManager.LoadScene(4);
        StageofOrigen += (selectNum + 7);
    }

    public void Stage8()
    {
        SceneManager.LoadScene(4);
        StageofOrigen += (selectNum + 8);
    }
    public int selectnumber()
    {
        return selectNum;
    }
    public void Setselectnumber(int a)
    {
        selectNum=a;
    }
    public int GetOrigin()
    {
        return StageofOrigen;
    }
    public void SetOrigin(int a)
    {
        StageofOrigen = a;
    }
}