using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuCanvasScript : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public void ResumePlay()
    {

        PlayPauseScript.IsPlaying = true;

        pauseMenuUI.SetActive(false);

    }
    public void BackToMenu()
    {
        //Build index of main menu scene is 0
        SceneManager.LoadScene(0);

    }
    public void QuitPlay()
    {

        Application.Quit();

    }
}
