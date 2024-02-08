using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D ball;
    public Transform finalPortal;
    private Transform MuzzleTransform2D;

    private Transform PlayerTransform2D, Portal1Transform2D, Portal2Transform2D;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        MuzzleTransform2D = GameObject.FindGameObjectWithTag("MuzzlePoint").GetComponent<Transform>();
        this.transform.position = MuzzleTransform2D.position;

        Portal2Transform2D = GameObject.FindGameObjectWithTag("PortalBlue2").GetComponent<Transform>();
        // Start is called before the first frame update

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            ball.gravityScale *= -1;
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 10){
            this.transform.position = Portal2Transform2D.position;
        }
        if(other.gameObject.tag == "PortalBlue2")
        {
            transform.position = finalPortal.transform.position;
        }
        
    }
    }
    

