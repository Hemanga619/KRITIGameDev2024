using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMotionY : MonoBehaviour
{
    // Start is called before the first frame update
    
    Vector2 difference = Vector2.zero;
    Camera cameras;

    // Start is called before the first frame update
    void Start()
    {
        cameras = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    
    private void OnMouseDown() {
        // Record the difference between the objects centre, and the clicked point on the camera plane.
        difference = (Vector2)cameras.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    
    private void OnMouseDrag(){
        transform.position = new Vector2(transform.position.x,((Vector2)cameras.ScreenToWorldPoint(Input.mousePosition) - difference).y);
    }
    
}
