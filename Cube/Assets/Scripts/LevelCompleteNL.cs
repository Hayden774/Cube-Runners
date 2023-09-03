using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteNL : MonoBehaviour
{
    public void LoadNextLevel (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
