﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class SwordSwing : MonoBehaviour {

    //TOFIX: sword slowly moves right and forward with each swing until it is floating ahead and to the right

    enum SwingState { held, back, forward };
    const float swing = 0.26f;

    float timer = 0;
    bool swinging = false;
    float swingTime = 0.25f;

    int currentWeapon;

    SwingState state = SwingState.held;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    // Use this for initialization
    void Start()
    {
        initialPosition = transform.localPosition;
        initialRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == SwingState.held)
        {
            transform.localRotation = initialRotation;
            transform.localPosition = initialPosition;

            if (Input.GetMouseButtonDown(0))
            {
                state = SwingState.forward;
                timer = 0;
            }
        }

        if (state == SwingState.forward)
        {
            timer += Time.deltaTime;

            if (timer > swingTime)
            {
                state = SwingState.back;
                timer = 0;
            }
        }

        if (state == SwingState.back)
        {
            timer += Time.deltaTime;

            if (timer > swingTime)
            {
                state = SwingState.held;
                timer = 0;
            }
        }


    }

    private void FixedUpdate()
    {
        if (state == SwingState.forward)
        {
            transform.Translate(Vector3.forward * swing);
            transform.Rotate(Vector3.down * 5);
            transform.Rotate(Vector3.right * 5);
        }
        if (state == SwingState.back)
        {
            transform.Translate(Vector3.back * swing);
            transform.Rotate(Vector3.up * 5);
            transform.Rotate(Vector3.left * 5);
        }
    }
}
