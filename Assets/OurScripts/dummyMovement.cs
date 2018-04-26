using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyMovement : MonoBehaviour
{
    public ParticleSystem psystem;

    bool hit = false;

    private Vector3 initialPos;
    private Vector3 initialRot;

    private const float kEpsilon = 0.028f;

    Vector3 newPos;
    Vector3 returnMovement;

    // Use this for initialization
    void Start()
    {
        initialRot = transform.eulerAngles;
        initialPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > initialPos.x + kEpsilon || transform.localPosition.x < initialPos.x - kEpsilon || transform.localPosition.x > initialPos.x + kEpsilon || transform.localPosition.x < initialPos.x - kEpsilon)
        {
            newPos = transform.localPosition;
            returnMovement = newPos - initialPos;
            hit = true;
        }
        else
        {
            hit = false;
            
        }
    }

    private void FixedUpdate()
    {
        if (hit == true)
        {
            Debug.Log("It has been Hit");
            transform.position = initialPos;
            transform.Rotate(-transform.eulerAngles);
            transform.eulerAngles = initialRot;
            initialPos = transform.position;
            hit = false;
            psystem.Play();
        }
    }
}
