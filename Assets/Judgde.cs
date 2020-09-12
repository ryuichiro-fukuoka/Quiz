using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Judgde : MonoBehaviour
{
    //選択したボタンのテキストと正解のテキストを比較して正誤の判定
    public void JudgdeAnswer()
    {
        //正解ののデータを変数"answerText"にセット
        string answerText = "井端弘和";
        //選択したボタンのテキストを取得
        Text selectedBtn = this.GetComponentInChildren<Text>();

        if (selectedBtn.text == answerText)
        {
            ResultMgr.SetJudgeData("正解");
            SceneManager.LoadScene("Result");
        }
        else
        {
            ResultMgr.SetJudgeData("不正解");
            SceneManager.LoadScene("Result");

        }
    }

}


