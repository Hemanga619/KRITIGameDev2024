using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D ball;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            ball.gravityScale *= -1;
        }
    }
}