using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    stagecriate stagecriate;                //LoadScene(4)はゲームシーンに飛ぶよ。
    int selectNum = 0;                      //何だっけ
    static int StageofOrigen = 0;           //今なんステージか
    static string[] flg = new string[24];   //そのステージをクリアしたかのフラグだよ

    public void Title()
    {
        SceneManager.LoadScene(0);//セレクトを再読み込み
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(3);
    }

    public void Stage()
    { int a = StageofOrigen += (selectNum +1 );
        if (flg[a] == "crear" || a == 1)
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;//+= (selectNum + 1);
        }
        
        //Debug.Log(selectNum);
    }

    public void Stage2()
    {
        int a = StageofOrigen += (selectNum + 2);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 2);
        }
        
    }

    public void Stage3()
    {
        int a = StageofOrigen += (selectNum + 3);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 3);
        }
        
    }

    public void Stage4()
    {
        int a = StageofOrigen += (selectNum + 4);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 4);
        }
        
    }

    public void Stage5()
    {
        int a = StageofOrigen += (selectNum + 5);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 5);
        }
        
    }

    public void Stage6()
    {
        int a = StageofOrigen += (selectNum + 6);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 6);
        }
        
    }

    public void Stage7()
    {
        int a = StageofOrigen += (selectNum + 7);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 7);
        }
        
    }

    public void Stage8()
    {
        int a = StageofOrigen += (selectNum + 8);
        if (flg[a] == "crear")
        {
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 8);
        }
        
    }
    //public int selectnumber()
    //{
    //    return selectNum;
    //}
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
    public string Getflg(int a)
    {
        return flg[a];          //クリアしたかのフラグを送るよ
    }
    public void Setflg(int a)
    {
        flg[a] = "crear";       //クリアしたかのフラグにチェックを入れるわけだよ
    }
}