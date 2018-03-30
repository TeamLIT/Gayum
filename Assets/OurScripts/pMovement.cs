using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovement : MonoBehaviour
{

    public float walkSpeed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float runSpeed = 8.0F;
    public float gravity = 20.0F;
    public float strafeSpeed = 0.3f;
    public GameObject spear;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= walkSpeed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * strafeSpeed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            spear.GetComponent<spearThrow>().fired = true;
            //spear.GetComponent<Rigidbody>().AddForce(transform.forward);
            spear.transform.parent = null;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * strafeSpeed);
        }

    }

}
