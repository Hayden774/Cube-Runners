using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
   bool GamehasEnded = false;

   public float RestartDelay = 1f;

   public GameObject CompleteLevelUI;

    public void Gameover(){

        if (GamehasEnded == false){
            GamehasEnded = true;
        Debug.Log("GAME OVER");
        Invoke("Restart", RestartDelay);
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel (){
        CompleteLevelUI.SetActive(true);
    }
}
