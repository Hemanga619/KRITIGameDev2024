using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private GameObject door;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(door);
        }
    }
}
