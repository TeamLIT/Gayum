using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearThrow : MonoBehaviour {

    public bool fired;

	// Use this for initialization
	void Start () {
        fired = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (fired)
        {
            transform.Translate(Vector3.forward);
        }
    }
}
