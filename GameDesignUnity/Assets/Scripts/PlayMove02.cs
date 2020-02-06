using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(CharacterController))]
public class PlayMove02 : MonoBehaviour
{
    //playermovement script
    
    private Vector3 position;
    private CharacterController controller;
    
    public float MoveSpeed = 10f;
    public float Gravity = 9.81f;
    public float JumpSpeed = 30f;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        position.x = MoveSpeed*Input.GetAxis("Horizontal");
        position.z = MoveSpeed*Input.GetAxis("Vertical");
        position.y -= Gravity;

        if (controller.isGrounded)
        {
            position.y = 0;
           
        }
        if(Input.GetButtonDown("Jump"))
        {
            position.y = JumpSpeed;
        }
        
        controller.Move(position*Time.deltaTime);
    }
}