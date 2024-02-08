using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMotion : MonoBehaviour
{
    [SerializeField] private float rotationRate=0.5f;
    private Quaternion rotation_r;
    private bool rotatable;
    // Start is called before the first frame update
    void Start()
    {
        rotation_r = this.transform.rotation; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rotatable){
        // if(Input.GetKey(KeyCode.R)){
        //     rotation_r.z += rotationRate;
        // }
        // if(Input.GetKey(KeyCode.K)){
        //     rotation_r.z -= rotationRate;
        // }
        // this.transform.rotation = rotation_r;
        if (Input.GetKey(KeyCode.R))  
            transform.Rotate(new Vector3(0f, 0f, rotationRate ));

        if(Input.GetKey(KeyCode.T))
            transform.Rotate(new Vector3(0f, 0f, -rotationRate ));
    }
    }


    void OnMouseDown(){
        rotatable = true;
    }
    void OnMouseUp(){
        rotatable = false;
    }

}

