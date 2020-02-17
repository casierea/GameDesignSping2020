using UnityEngine;
using UnityEngine.Serialization;
	
[RequireComponent(typeof(CharacterController))]
public class CharControl : MonoBehaviour
{
    //playermovement script
	    
    private Vector3 position;
    private CharacterController controller;
	    
    public float MoveSpeed = 10f;
    public float Gravity = 5f;
    public float JumpSpeed = 30f;

	private bool dirHorizontal = false;
	private Vector3 MoveDir = Vector3.zero;

	private Vector3 DoNotRote;
	
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

	private void Update()
	{
		if (controller.isGrounded)
		{
			MoveDir = new Vector3(Input.GetAxis("Horizontal"),0.0f, Input.GetAxis("Vertical"));
			MoveDir *= MoveSpeed;
		}

		if (MoveDir!= Vector3.zero)
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(MoveDir),0.15f);
		}
		
		if (Input.GetButtonDown("Jump"))
		{
			MoveDir.y = JumpSpeed;
			//position.y = JumpSpeed;
		}

		MoveDir.y -= Gravity * Time.deltaTime;
		controller.Move(MoveDir * Time.deltaTime);

		
	}

	void Rotate()
	{
		transform.Rotate(0,90,0);
	}
	
   // void Update()
   // {
     //  position.x = MoveSpeed*Input.GetAxis("Horizontal");
       // position.z = MoveSpeed*Input.GetAxis("Vertical");
      //  position.y -= Gravity;
	
        //if (controller.isGrounded)
       // {
       //     position.y = 0;
	           
       // }
       // if(Input.GetButtonDown("Jump"))
       // {
       //     position.y = JumpSpeed;
       // }
	        
       // controller.Move(position*Time.deltaTime);
    //}//
}