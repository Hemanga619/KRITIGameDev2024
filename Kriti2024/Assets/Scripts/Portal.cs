
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform teleportPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = teleportPoint.position;
    }

}
