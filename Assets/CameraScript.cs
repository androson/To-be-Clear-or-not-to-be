using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject cameraHolder;
    [SerializeField] float sensitivity;
    float mouseX;
    float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        Mathf.Clamp(mouseX, -60, 60);
        transform.rotation = Quaternion.Euler(0, mouseX, 0);
        cameraHolder.transform.rotation = Quaternion.Euler(-mouseY, mouseX, 0);
    }
}
