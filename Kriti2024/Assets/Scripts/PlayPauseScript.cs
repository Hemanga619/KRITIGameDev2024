using UnityEngine;

public class PlayPauseScript : MonoBehaviour
{
    public static bool IsPlaying = false;

    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (IsPlaying)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }
    }
}
