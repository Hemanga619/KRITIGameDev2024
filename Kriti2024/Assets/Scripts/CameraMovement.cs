using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    public float CameraSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            CameraPosition.y += CameraSpeed;
        }
        if(Input.GetKey(KeyCode.S)){
            CameraPosition.y -= CameraSpeed;
        }
        if(Input.GetKey(KeyCode.D)){
            CameraPosition.x += CameraSpeed;
        }
        if(Input.GetKey(KeyCode.A)){
            CameraPosition.x -= CameraSpeed;
        }

        this.transform.position = CameraPosition;

    }
    

    private void FixedUpdate()
    {
        
    }
}
