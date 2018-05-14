using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class counter : MonoBehaviour {
    public clicker clicker;         //Clickerスクリプトとこのスクリプトを結び付けるアレ
    public Text printer,famiport;   //スコアに関するText

    public Image evoblock,vaji;          //進化素材イメージファイル。使うと非表示にする。
    public Text evotxt,vajitext;             //進化素材テキスト。同じく使うと非表示に。


    // Use this for initialization
    void Start () {
        vaji.enabled = false;
        vajitext.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        printer.text = clicker.page.ToString("F0")+"萬円";
        famiport.text = "ファミポートの値段は\n" + clicker.Getfamiport_yen().ToString("F0") + "萬円";

        if (clicker.Getevo() != 0) { evoblock.enabled = false;
            evotxt.enabled = false;
            vaji.enabled = true;
            vajitext.enabled = true;}
        if (clicker.Getvaji() != 0)
        {
            vaji.enabled = false;
            vajitext.enabled = false;
        }
    }
}
