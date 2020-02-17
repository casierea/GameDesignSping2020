using UnityEngine;
using UnityEngine.Serialization;
	
[RequireComponent(typeof(CharacterController))]
public class BasicCharControl : MonoBehaviour
{
    
	    
    private Vector3 position;
    private CharacterController controller;
	    
    public float MoveSpeed = 10f;
    public float Gravity = 3f;
    public float JumpSpeed = 40f;
	private float RotationSpeed = 100f;
	
	
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

	        if (position != Vector3.zero)
	        {
		        controller.transform.forward = position;
	        }
        }
        if(Input.GetButtonDown("Jump"))
        {
            position.y = JumpSpeed;
        }
	        
        controller.Move(position*Time.deltaTime);
    }
}