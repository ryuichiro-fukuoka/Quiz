using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        QuestionLabelSet();
        AnswerLabelSet();
    }

    private void QuestionLabelSet(){
         //特定の名前のオブジェクトを検索してアクセス
        Text qLabel = GameObject.Find("Quiz/Qlabel").GetComponentInChildren<Text> ();
        //データをセットすることで、既存情報を上書きできる
        qLabel.text = "この中で、通算安打数が2000本に届いていない選手はだれか";
    }

    private void AnswerLabelSet(){
        //回答部分の作成
        string[] array = new string[] {"福浦和也","井端弘和","荒木雅博","鳥谷敬"};
         //ボタンが4つあるのでそれぞれ代入
        for (int i=1; i<=4 ; i++){
            Text ansLabel = GameObject.Find("Quiz/AnsButton" + i).GetComponentInChildren<Text> ();
            ansLabel.text = array[i-1];
        }
    }
}
