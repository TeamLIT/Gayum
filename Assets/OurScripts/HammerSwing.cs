using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSwing : MonoBehaviour {

    enum SwingState { held, back, forward };
    const float swing = 0.07f;

    float timer = 0;
    bool swinging = false;
    float swingTime = 0.7f;

    SwingState state = SwingState.held;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (state == SwingState.held)
        {
            if (Input.GetKeyDown(KeyCode.R))
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
            transform.Rotate(Vector3.down * 1.5f);
            transform.Rotate(Vector3.right * 1.5f);
        }
        if (state == SwingState.back)
        {
            transform.Translate(Vector3.back * swing);
            transform.Rotate(Vector3.up * 1.5f);
            transform.Rotate(Vector3.left * 1.5f);
        }
    }
}


