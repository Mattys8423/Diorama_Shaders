using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 2f;

    private float verticalRotation = 0f; 
    private void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -70f, 70f);

        transform.localEulerAngles = new Vector3(verticalRotation, 0f, 0f);
    }
}