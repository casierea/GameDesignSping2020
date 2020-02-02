using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove03 : MonoBehaviour 

{

    private CharacterController Controller;
    public bool CanMove = false;
    public float Gravity = 9.81f;
    public float MoveSpeed = 3.0f;
    public float JumpSpeed = 3.0f;
    public bool FacingLeft;
    private float Scalex;
    private Vector3 position;
    private Vector3 rotation;
	
    void Start ()
    {
        Controller = GetComponent<CharacterController>();
        Scalex = transform.localScale.x;
    }

    public void StartMovement()
    {
        CanMove = true;
        StartCoroutine(Move());
    }

    public void StopMovement()
    {
        CanMove = false;
    }
    
    IEnumerator Move ()
    {
        while (CanMove)
        {


            if (Controller.isGrounded)
            {
                position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, 0);
                // rotation.Set(0, Input.GetAxis("Vertical"), 0);
                //transform.Rotate(rotation);
                position = transform.TransformDirection(position);

                if (Input.GetButton("Jump"))
                {
                    position.y = JumpSpeed;
                }
            }

            flipSprite();
            position.y -= Gravity * Time.deltaTime;
            Controller.Move(position * Time.deltaTime);

            yield return null;
        }
    }

    private void flipSprite()
    {
        var facing = Input.GetAxis("Horizontal");
        if (facing > 0.0f)
        {
            Vector3 Scale = transform.localScale;
            Scale.x = -Scalex;
            transform.localScale = Scale;
            FacingLeft = false;
        }
        else if (facing < 0.0f)
        {
            Vector3 Scale = transform.localScale;
            Scale.x = Scalex;
            transform.localScale = Scale;
            FacingLeft = true;
        }
        
    }
   
}