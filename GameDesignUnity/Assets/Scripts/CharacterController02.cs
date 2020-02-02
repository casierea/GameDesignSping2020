using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterController02 : MonoBehaviour
{
    private CharacterController controller;

    private float Gravity = 9.81f;
    public float MoveSpeed = 3.14f;
    private Vector3 Rot;

    public Vector3 position;
    
    public float JumpSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, MoveSpeed * Input.GetAxis("Vertical"));
            position = transform.TransformDirection(position);
           
        }
        position.y -= Gravity * Time.deltaTime;
        controller.Move(position * Time.deltaTime);
    }
}