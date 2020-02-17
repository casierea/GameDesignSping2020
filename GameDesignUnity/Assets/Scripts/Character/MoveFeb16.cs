using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.Mathematics;
using UnityEngine;

public class MoveFeb16 : MonoBehaviour

//Nats for undertstanding. Want to go back and undertsand Quaterions
{
    private CharacterController charController;
    private Vector3 position;
    private Vector3 movement;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float rotateSpeed = 2.0f;
    public float gravity = 20.0f;

    private bool goHorizontal = false;
    
    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (charController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
           
        }

        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation( moveDirection),0.15f );
        }


        moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(moveDirection * Time.deltaTime);
        
        
    }

    void Rotate()
    {
        transform.Rotate(0, 90, 0);
    }

    
}