using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensX;
    public float sensY;

    float xRotation;
    float yRotation;

    public Camera mainCam;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;


        //Limit rotation - static
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        mainCam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        gameObject.transform.Rotate(Vector3.up * mouseX);
    }




}
