using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(CharacterController))]
public class GoMove : MonoBehaviour
//kaitlyn script for practice and understanding

{
   
    private Vector3 position;
    private CharacterController controller;
    
    public float moveSpeed = 10f, jumpSpeed = 30f, rotationSpeed = 100;
    public float gravity = 9.81f;
    
    private int jumpCount;
    public int jumpCountMax = 2;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.z = moveSpeed*Input.GetAxis("Vertical");
        position.y -= gravity;
        
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
            if (position  != Vector3.zero)
            {
                controller.transform.forward = position;
            }
        }
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        controller.Move(position*Time.deltaTime);
    }
}