using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrafeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * 0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 0.1f);
        }

    }
}
