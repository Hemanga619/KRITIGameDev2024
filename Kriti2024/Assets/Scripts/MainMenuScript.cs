using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene(8);
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene(9);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
