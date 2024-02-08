using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyWall : MonoBehaviour
{
    private bool sticked;
    private Rigidbody2D PlayerRB2D;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sticked){
            PlayerRB2D.velocity = new Vector2(0,0);
            PlayerRB2D.gravityScale = 0.0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.layer==6){
            sticked = true;
        }
    }
}
