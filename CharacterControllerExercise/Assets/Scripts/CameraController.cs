﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _mouseMovementX = 1f;
    //[SerializeField] private float _mouseMovementY = .1f;

    private Transform parent;
    private Camera _fpsCamera;

    // Start is called before the first frame update
    void Start()
    {
        
        _fpsCamera = Camera.main;
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalRotation = Input.GetAxis("Mouse X") * _mouseMovementX;
        //float verticalRotation = Input.GetAxis("Mouse Y") * _mouseMovementY;

        parent.Rotate(0, horizontalRotation, 0);
        //_fpsCamera.transform.Rotate(-verticalRotation, 0, 0);
        

        float movementX = Input.GetAxis("Mouse X") * _mouseMovementX * Time.deltaTime;

        parent.Rotate(Vector3.up, movementX);
        
    }
}
