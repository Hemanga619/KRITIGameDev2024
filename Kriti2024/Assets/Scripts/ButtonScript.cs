using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public void StartPlay()
    {
        if (PlayPauseScript.IsPlaying)
        {
            PlayPauseScript.IsPlaying = false;
        }
        else
        {
            PlayPauseScript.IsPlaying = true;
        }
    }

    public void PausePlay()
    {

        PlayPauseScript.IsPlaying = false;
        pauseMenuUI.SetActive(true);

    }
}
