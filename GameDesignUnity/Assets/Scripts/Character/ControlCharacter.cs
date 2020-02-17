using UnityEngine;

public class ControlCharacter : MonoBehaviour
{

    public CharacterController controller;

    public Vector3 Location, Orientation;

    public float speed = 12f, orientSpeed = 4f, gravity = -9.81f, jumpSpeed = 80f;
    
   
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            Location.x = (Input.GetAxis("Vertical")*speed);
            Location.z = 0;
            Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
            controller.transform.Rotate(Orientation);
            Location = controller.transform.TransformDirection(Location);
        }
        
        
        
        if (Input.GetButtonDown("Jump"))
        {
            Location.y = jumpSpeed;
        }
        
        
        Location.y += gravity;
        
        controller.Move(Location * Time.deltaTime);

    }

}