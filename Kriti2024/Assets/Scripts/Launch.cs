using UnityEngine;

public class Launch : MonoBehaviour
{
    private bool launchable = false;
    private Rigidbody2D PlayerRB2D , MuzzleRB2D;
    private Transform PlayerTransform2D, BallLauncherTransform2D;
    [SerializeField] private Transform MuzzlePointTransform2D;
    Renderer ren;
    public float ballVelocity = 0.01f;
    private Quaternion ballLauncherAngle;
    private float x_component;
    private float y_component;
    public float interval = 0.01f;
   [HideInInspector] public LineRenderer lr;
    public int PointsNumber = 200;
    private Vector2 direction;

    private void Start(){
        ren = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();
        ren.enabled=true;
        PlayerRB2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        PlayerTransform2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        BallLauncherTransform2D = GetComponent<Transform>();
        lr = GetComponent<LineRenderer>();
        
    }

    private void Update(){
        if(launchable){
            PlayerRB2D.velocity = new Vector2 (0,0);

            PlayerTransform2D.position = MuzzlePointTransform2D.position;
	        
	        PlayerRB2D.gravityScale *= 0.0f;

            ballLauncherAngle = BallLauncherTransform2D.rotation;
            
        }

        direction = MuzzlePointTransform2D.transform.up*100 - MuzzlePointTransform2D.transform.position;
        
        
        if(Input.GetKey(KeyCode.Space) && launchable){
                launchable = false;
                ren.enabled = true;
                PlayerRB2D.gravityScale += 1.0f;
                
                x_component = direction.x/100*ballVelocity;
                y_component = direction.y/100*ballVelocity;

                PlayerRB2D.velocity = new Vector2(x_component,y_component);
                

            }
        if(lr != null){
        DrawTrajectory();}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
        {
            launchable = true;
            ren.enabled=false;
        }
    }

    void DrawTrajectory(){
        Vector2 origin = MuzzlePointTransform2D.position;
        x_component = direction.x/100*ballVelocity;
        y_component = direction.y/100*ballVelocity;
        float time = 0;
        lr.positionCount = PointsNumber;
        for(int i=0 ; i<PointsNumber ; i++){
            float x = x_component*time;
            float y = y_component*time- (1f/2f)*time*time*10f;
            Vector2 point = new Vector2(x,y);
            lr.SetPosition(i,origin+point);
            time += interval;
        }
    }
    


       
}
