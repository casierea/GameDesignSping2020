using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{

    private Vector3 position;

    private CharacterController controller;

    public float moveSpeed = 10f;
    public float gravity = 9.81f;
    public float jumpSpeed = 30f;
    public float jumpCount;
    //public flaot jumpCountMax;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
