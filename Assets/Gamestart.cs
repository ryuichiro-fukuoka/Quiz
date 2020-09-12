using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour{
    public static int qCount;
    public void NextScene(){
        // 今いるシーンがTitleという名前なら、Quizという名前に変化する。
        if(SceneManager.GetActiveScene ().name == "Title"){ 
            SceneManager.LoadScene("Quiz");
        }
    }

    public void NextQuiz(){
        if(SceneManager.GetActiveScene().name == "Result"){
            if(qCount < 2){
                qCount++;
                SceneManager.LoadScene("Quiz");
            }else{
                qCount = 0;
                SceneManager.LoadScene("Score");
            }    
        }
    }

    public void BackTotitle(){
        if(SceneManager.GetActiveScene().name == "Score"){
            ResultMgr.SetScoreData(0);
            SceneManager.LoadScene("Title");
        }
    }
  
    
}
