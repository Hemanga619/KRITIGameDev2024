using UnityEngine;

public class booster : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float boostSpeed = 3f;
    [SerializeField] private float v_y = 10f;
    [SerializeField] private float v_x = 5f;
    //[SerializeField] private float down = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(v_x, v_y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boost")
        {
            rb.velocity = rb.velocity * boostSpeed;
            Debug.Log(rb.velocity.magnitude);
        }
    }
}
