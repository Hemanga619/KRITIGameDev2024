using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb = new Rigidbody2D();
    public float bounciness = 0.97f;
    private int powerups = 0;
    bool isBallMetal = false;
   
    int collisionAfterPowerUp = 0;
    private Vector3 originalVelocity;
    private SpriteRenderer objMesh;
    [HideInInspector] public  bool isTeleport = false;
    [HideInInspector] public  Vector3 initialPosition;
    public CircleCollider2D coll;
    
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        objMesh = GetComponent<SpriteRenderer>();
        coll = GetComponent<CircleCollider2D>();
    }

    void Update()
    {       
        if(collisionAfterPowerUp>0)
            {
                coll.sharedMaterial.bounciness = 0.97f;
                collisionAfterPowerUp =0;
            }
    }

   
    public float powerUpTimeDuration = 3f;
    float powerUpTimeStart = 0f;
    float timeLeft = 3f;
    bool powerUpEnabled = false;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.tag == "Powerup")
       {
        powerUpEnabled = true;
        PowerUpStart();
        other.gameObject.SetActive(false);
        Invoke(nameof(PowerUpEnd),timeLeft);
       }    
    }
   
   void PowerUpStart()
   {
    rb.mass*=3;
    
    coll.sharedMaterial.bounciness = 0.5f;
    
   }

    void PowerUpEnd()
    {
        rb.mass/=3;
        
        coll.sharedMaterial.bounciness = 0.97f;
        powerUpEnabled = false;
        timeLeft = 3f;
        
    
    }
    private void OnCollisionEnter2D(Collision2D other) {
 
        if(powerUpEnabled)
        {
            collisionAfterPowerUp++;
        }
        

    }
}