using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float rayDistance = 100;
    public Transform FirePoint;
    public LineRenderer lineRenderer_r;
    Transform transform_r;
    public GameObject other;

    private void Start(){
        transform_r = GetComponent<Transform>();
    }

    private void Update(){
        ShootLaser();
    }

    void ShootLaser(){
        RaycastHit2D hit = Physics2D.Raycast(transform_r.position , transform.right);
        if(hit){
            Draw2DRay(FirePoint.position,hit.point);
            
            if(hit.collider.name=="Player"){
                
                Destroy(other);
            }
        }
        else{
            Draw2DRay(FirePoint.position , FirePoint.transform.right*rayDistance);
        }
    }

    void Draw2DRay(Vector2 s_pos , Vector2 e_pos){
        lineRenderer_r.SetPosition(0,s_pos);
        lineRenderer_r.SetPosition(1,e_pos);
    }
}
