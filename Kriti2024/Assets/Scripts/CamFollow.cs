using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform playerobject;
    [SerializeField]
    public float teleportTime = 2f;
    private float camSpeed;
    // Start is called before the first frame update
    void Start()
    {
        camSpeed =  ((FindObjectOfType<BallMovement>().finalPosition- FindObjectOfType<BallMovement>().initialPosition).magnitude)/ teleportTime;
        Debug.Log(camSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(!FindObjectOfType<BallMovement>().isTeleport)
        {
        transform.position = playerobject.transform.position + new Vector3(0,-playerobject.transform.position.y+1f,-10f);
        }
        if(FindObjectOfType<BallMovement>().isTeleport)
        {
            transform.position+= (FindObjectOfType<BallMovement>().finalPosition- FindObjectOfType<BallMovement>().initialPosition).normalized* camSpeed * Time.deltaTime;
            Debug.Log(FindObjectOfType<BallMovement>().finalPosition- FindObjectOfType<BallMovement>().initialPosition);
        }
        
        
    }
    

    
}
