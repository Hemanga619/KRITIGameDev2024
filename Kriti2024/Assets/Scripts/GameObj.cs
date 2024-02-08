using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObj : MonoBehaviour
{
    bool gameEnded = false;

    public void EndGame()
    {
        if(gameEnded == false)
        {
            Debug.Log("Game Over!");
            gameEnded = true;
            Invoke("RestartGame",1.5f);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
