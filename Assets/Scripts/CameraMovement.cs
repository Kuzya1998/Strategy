using System;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    
    
    [SerializeField] private float panSpeed = 20f;
    [SerializeField] private float panBorderThickness = 10f;
    [SerializeField] private Vector2 panLimit;
    [SerializeField] private float scrollSpeed = 20f;
    
    [SerializeField] private float minY = 20f;
    [SerializeField] private float maxY = 120f;
    

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
    
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;
    
        pos.x = Math.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Math.Clamp(pos.y, minY, maxY);
        pos.z = Math.Clamp(pos.z, -panLimit.y, panLimit.x);
    
    

        transform.position = pos;
    }
    
    
}
