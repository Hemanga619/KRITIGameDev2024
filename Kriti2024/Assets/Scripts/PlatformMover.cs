using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    private GameObject currentPlatform;
    private Vector3 offset;
    void Start()
    {
        currentPlatform = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayPauseScript.IsPlaying)
        {


            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D platform = Physics2D.OverlapPoint(mousePosition);

                if (platform == GetComponent<BoxCollider2D>())
                {
                    currentPlatform = platform.transform.gameObject;
                    offset = currentPlatform.transform.position - mousePosition;
                }
            }

            if (currentPlatform)
            {
                currentPlatform.transform.position = mousePosition + offset;
            }
            if (Input.GetMouseButtonUp(0) && currentPlatform)
            {
                currentPlatform = null;
            }

        }
    }
}
