using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour{
    public void NextScene(){
        // 今いるシーンがTitleという名前なら、Quizという名前に変化する。
        if(SceneManager.GetActiveScene ().name == "Title"){ 
            SceneManager.LoadScene("Quiz");
        }
    }

    public void NextQuiz(){
        if(SceneManager.GetActiveScene().name == "Result"){
            SceneManager.LoadScene("Quiz");
        }
    }
  
}
