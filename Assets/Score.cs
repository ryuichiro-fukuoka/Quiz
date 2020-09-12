using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        //スコア表示用のゲームオブジェクトを習得
        Text scoreLabel = GameObject.Find("Canvas/Text").GetComponent<Text>();
        scoreLabel.color = Color.red;
        //グローバルに宣言したスコアをResuitMgrのスクリプトから読み込む
        int Score = ResultMgr.GetScoreData();
        scoreLabel.text = Score.ToString() + "点";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
