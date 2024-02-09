using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    private float CameraSpeed = 0.01f;
    [SerializeField] private Vector3 centerPoint;
    private Vector3 originalCamPos;
    private float originalZoomView;
    [SerializeField] private float zoomView;
    private Camera MainCamera;
    private bool isZoom;

    void Start()
    {
        isZoom = false;
        MainCamera = GetComponent<Camera>();
        CameraPosition = this.transform.position;
        originalCamPos = transform.position;
        originalZoomView = MainCamera.orthographicSize;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            isZoom = !(isZoom);

        if (isZoom)
        {
            transform.position = centerPoint;
            MainCamera.orthographicSize = zoomView;
        }
        else
        {
            transform.position = new Vector3(originalCamPos.x, originalCamPos.y, originalCamPos.z);
            MainCamera.orthographicSize = originalZoomView;

            if (Input.GetKey(KeyCode.W))
            {
                CameraPosition.y += CameraSpeed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                CameraPosition.y -= CameraSpeed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                CameraPosition.x += CameraSpeed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                CameraPosition.x -= CameraSpeed;
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                CameraPosition.y += CameraSpeed * 1.5f;
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
            {
                CameraPosition.y -= CameraSpeed * 1.5f;
            }
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            {
                CameraPosition.x += CameraSpeed * 1.5f;
            }
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
            {
                CameraPosition.x -= CameraSpeed * 1.5f;
            }

            this.transform.position = CameraPosition;
            originalCamPos = transform.position;
        }
    }
}
