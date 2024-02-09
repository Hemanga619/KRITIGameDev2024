using UnityEngine;

public class LoadScreen : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();

        Invoke("IdleScreen", 1f);
    }
    private void IdleScreen()
    {
        animator.SetBool("isIdle", true);
    }
}
