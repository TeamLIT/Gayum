using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearThrust : MonoBehaviour {

    //TOFIX: spear sometimes stays 1s ahead of where it should be instead of going back to its original position


    enum ThrustingState { held, back, forward };
    const float thrust = 0.26f;

    float timer = 0;
    float thrustTime = 0.25f;

    ThrustingState state = ThrustingState.held;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    // Use this for initialization
    void Start ()
    {
        initialPosition = transform.localPosition;
        initialRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update () {
        if (state == ThrustingState.held)
        {
            transform.localRotation = initialRotation;
            transform.localPosition = initialPosition;

            if (Input.GetKeyDown(KeyCode.R))
            {
                state = ThrustingState.forward;
                timer = 0;
            }
        }

        if (state == ThrustingState.forward)
        {
            timer += Time.deltaTime;

            if (timer > thrustTime)
            {  
                state = ThrustingState.back;
                timer = 0;
            }
        }

        if (state == ThrustingState.back)
        {
            timer += Time.deltaTime;

            if (timer > thrustTime)
            {
                state = ThrustingState.held;
                timer = 0;
            }
        }

       
    }

    private void FixedUpdate()
    {
        if (state == ThrustingState.forward)
        {
            transform.Translate(Vector3.forward * thrust);
        }
        if (state == ThrustingState.back)
        {
            transform.Translate(Vector3.back * thrust);
        }
    }
}
