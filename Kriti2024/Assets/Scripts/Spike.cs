using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);
            MainMenuScript.levelIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(2);
        }
    }
}
