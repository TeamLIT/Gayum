using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyMovement : MonoBehaviour
{
    bool hit = false;

    float timer = 0.0f;

    private Vector3 initialPos;
    Vector3 newPos;
    Vector3 returnMovement;

	// Use this for initialization
	void Start ()
    {
        initialPos = transform.localPosition;
	}

    // Update is called once per frame
    void Update ()
    {
        if (transform.localPosition != initialPos)
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
            transform.position = initialPos;
            hit = false;
        }
    }
}
