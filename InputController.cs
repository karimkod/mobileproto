﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        var initialPosition = Input.mousePosition;
        bool isFingerTouching = true;

        if (Input.GetMouseButtonDown(0) && isFingerTouching == true)
        {
            Vector3 movement = (Input.mousePosition - initialPosition);
            
        }

        else if (Input.GetMouseButtonDown(0) && isFingerTouching == false)
        {
            speed = 0;
        }
    }
}
