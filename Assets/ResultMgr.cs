﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultMgr : MonoBehaviour
{
    //他のスクリプトからも参照可能な変数定義
    public static string g_judgeData;
    public static int g_scoreData;
    void Start()
    {
        

        //デフォルトは正解、不正解なら画像と文言を切り替える
        if (g_judgeData == "不正解")
        {
            //現在描画している画像を取得
            SpriteRenderer judgeImage = GameObject.Find("JudgeUI/JudgeImage").GetComponent<SpriteRenderer>();
            //Resourcesから指定した名前の画像データをロード
            Sprite loadingImage = Resources.Load<Sprite>("batsu");
            //画像を置換
            judgeImage.sprite = loadingImage;
            //表示テキストを取得して置換
            Text judgeLabel = GameObject.Find("JudgeUI/JudgeLabel").GetComponent<Text>();
            judgeLabel.text = "不正解,ザッコwwwwwwwwwwwwwwwwwwww";
        }else if(g_judgeData == "正解"){
            g_scoreData++;
        }
    
    }

    //グローバルに宣言したスコアを他のスクリプトから読み込む
    public static int GetScoreData(){
        return g_scoreData;
    } 

    

    //グローバルに宣言したスコアを他のスクリプトから書き込む
    public static int SetScoreData(int scoreData){
        g_scoreData = scoreData;
        return g_scoreData;
    }
    public static void SetJudgeData(string judgeData)
    {
        g_judgeData = judgeData;
    }
}
