using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    stagecriate stagecriate;                //LoadScene(4)はゲームシーンに飛ぶよ。
    int selectNum = 0;                      //何だっけ
    static int StageofOrigen = 0;           //今なんステージか
    static string[] flg = new string[25];   //そのステージをクリアしたかのフラグだよ
    int a = StageofOrigen;
    private void Start()
    {
        flg[0] = "crear";
        flg[1] = "crear";
    }
    public void Title()
    {
        SceneManager.LoadScene(0);//セレクトを再読み込み
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(3);
    }

    public void Stage()
    {
        // a = a = a + selectNum + 1
        if (flg[a + selectNum + 1] != null) //flg[a] == "crear" || a == 1)
        {
            a = (a += selectNum + 1);
            SceneManager.LoadScene(2);
            StageofOrigen = a;//+= (selectNum + 1);
        }
    }

    public void Stage2()
    {
          //a=(a+=selectNum+ 2);
        if (flg[a+selectNum+2] != null) //flg[a] == "crear" || a == 1)
        {
            a = (a += selectNum + 2);
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 2);
        }
        //else { SceneManager.LoadScene(0); }
    }

    public void Stage3()
    {
         //a =(a +=selectNum+ 3);
        if (flg[a+selectNum+3] != null)
        {
            a = (a += selectNum + 3);
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 3);
        }
        
    }

    public void Stage4()
    {
         //a =(a+= 4);
        if (flg[a+selectNum+4] != null)
        {
            a = (a += selectNum + 4);
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 4);
        }
        
    }

    public void Stage5()
    {
        //a =(a+= 5);
        if (flg[a+selectNum+5] != null)
        {
            a = (a += selectNum + 5);
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 5);
        }
        
    }

    public void Stage6()
    {
        //a=(a + 6);
        if (flg[a+selectNum+6] != null)
        {
            a = (a += selectNum + 6);
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 6);
        }
        
    }

    public void Stage7()
    {
        //a=(a  + 7);
        if (flg[a+selectNum+7] != null)
        {
            a = (a += selectNum + 7);
            SceneManager.LoadScene(2);
            StageofOrigen = a;// (selectNum + 7);
        }
        
    }

    public void Stage8()
    {
        //a=(a + 8);
        if (flg[a+selectNum+8] != null)
        {
            a = (a += selectNum + 8);
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