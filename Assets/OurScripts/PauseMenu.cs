using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public bool paused = true;
    private GameObject pannelyboi;

    // Use this for initialization
    void Start()
    {
        pannelyboi = GameObject.Find("pPanel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (paused == true)
            {
                paused = false;
            }
            else
            {
                paused = true;
            }
        }

        if (paused == true)
        {
            pannelyboi.SetActive(false);
        }
        else
        {
            pannelyboi.SetActive(true);
        }
    }
}
