using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public static int levelIndex = 0;
    public void PlayButton()
    {
        levelIndex = 3;
        SceneManager.LoadScene(3);
    }
    public void OptionsButton()
    {
        levelIndex = 1;
        SceneManager.LoadScene(1);
    }
    public void CreditsButton()
    {
        levelIndex = 8;
        SceneManager.LoadScene(8);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void Back()
    {
        levelIndex = 0;
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
