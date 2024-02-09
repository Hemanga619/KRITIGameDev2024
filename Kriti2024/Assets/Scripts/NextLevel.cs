using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            animator.SetBool("isIdle2", false);           
            Invoke("LoadNextLevel", 1.2f);
        }
    }

    private void LoadNextLevel()
    {
        MainMenuScript.levelIndex += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ;
    }
}
