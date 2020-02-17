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
   // public float orientSpeed = 4f;
    //public Vector3 Orientation;
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
       SetFacing(controller);
    }
    
    void Update()
    {
        position.x = MoveSpeed*Input.GetAxis("Horizontal");
        position.z = MoveSpeed*Input.GetAxis("Vertical");
        position.y -= Gravity;
        SetFacing(controller);
       
        //Changed y to x in orientation.x
        //Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
        //controller.transform.Rotate(Orientation);

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

    private void SetFacing(CharacterController controller)
    {
     Quaternion Facing = controller.GetComponent<Transform>().rotation;

        Quaternion NewFacing;
        //lookRight = transform.rotation;
        //lookLeft = lookRight * Quaternion.Euler(0, 180, 0); 
        
        if (Input.GetAxis("Horizontal") < 0)
        {
            NewFacing = Facing * Quaternion.Euler(0, 180, 0);
            controller.GetComponent<Transform>().rotation = NewFacing;
            Debug.Log("0,180,0");
        }
        
        else if (Input.GetAxis("Horizontal") >= 0)
        {
            NewFacing = Facing * Quaternion.Euler(0, 0, 0);
            controller.GetComponent<Transform>().rotation = NewFacing;
            Debug.Log("0,0,0");
        }
        
        else if (Input.GetAxis("Vertical") < 0)
        {
            NewFacing = Facing * Quaternion.Euler(0, 90, 0);
           // controller.GetComponent<Transform>().rotation = NewFacing;
        }
        
        else if (Input.GetAxis("Vertical") > 0)
        {
            NewFacing = Facing * Quaternion.Euler(0, 270, 0);
            //controller.GetComponent<Transform>().rotation = NewFacing;
        }
        
        controller.Move(position*Time.deltaTime);
    }
   
}