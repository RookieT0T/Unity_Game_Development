using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse: MonoBehaviour
{
    public float mouseSensitivity = 1;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called in the beginning
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // looking up and down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // looking right and left
        playerBody.Rotate(Vector3.up * mouseX);
    }

    public void setSensitivity (float sens)
    {
        mouseSensitivity = sens;
    }
}