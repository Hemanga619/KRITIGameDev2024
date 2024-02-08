using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    Rigidbody2D rb1;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag() {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x,transform.position.x-4f,transform.position.x+4f),Mathf.Clamp(transform.position.y,-3.89f,-3.89f));
        rb1.isKinematic = true;
        rb1.gravityScale = 0;
    }

    private void OnMouseUp() {
        rb1.isKinematic = true;
        rb1.gravityScale = 0;
    }


    // Update is called once per frame
    
}