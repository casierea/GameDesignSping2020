using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class BossNav : MonoBehaviour
{
    //used in FixedUpdate
    public GameObject Player;
    public Rigidbody thruster;
    public float thrust;

    public Vector3 nav1;
    public Vector3 nav2;
    public Vector3 nav3;
    public Vector3 nav4;
    List<Vector3> navPoints = new List<Vector3>(); // empty now
    

    public GameObject thruster1;
    public GameObject thruster2;
    public GameObject thruster3;
    public GameObject thruster4;

    public int thrusterSpeed = 2;
    public int thrustTotal = 0;
    public int baseSpeed = 5;
    public int thrusterTotal = 0;
    [SerializeField] private Vector3 target = new Vector3(1, 1, 1);
    [SerializeField] private float speed = 1;
    
    // Start is called before the first frame update
    
    void Start()
    {
        nav1 = new Vector3(144, 4, -27);
        nav2 = new Vector3(75, 4, -27);
        nav3 = new Vector3(75, 4, 46);
        nav4 = new Vector3(144, 4, 46);
        navPoints.Add(nav1);
        navPoints.Add(nav2);
        navPoints.Add(nav3);
        navPoints.Add(nav4);
        //thrust = 1;
        //thrusterSpeed = 2;
        //baseSpeed = 5;
        
        thruster = GetComponent<Rigidbody>();
        target = Player.GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        thrusterCheck();
        moveTowards();
         
        if (Vector3.Distance(gameObject.GetComponent<Transform>().position, target) < 5)
        {
            changeDestination();    
            Debug.Log(target);
        }
        
        
    }
    void FixedUpdate()
    {
        
    }

    void fireThruster()
    {
        //move boss upwards like a jump
        //also look at impulse()
        thruster.AddForce(transform.forward * thrust);
    }


    void changeDestination()
    {

        navPoints.Add(Player.GetComponent<Transform>().position);
        // //
        int rand = Random.Range(0, navPoints.Count);
        target = navPoints[rand];
    }
    
    void moveTowards()
    {
        // Moves the object to target position
        
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
    
    public void thrusterCheck()
    {
        thrusterTotal = 0;
        
        if (thruster1)
        {
            thrusterTotal += thrusterSpeed;
        }
        if (thruster2)
        {
            thrusterTotal += thrusterSpeed;
        }
        if (thruster3)
        {
            thrusterTotal += thrusterSpeed;
        }
        if (thruster4)
        {
            thrusterTotal += thrusterSpeed;
        }

        speed = baseSpeed + thrusterTotal;
    }
}
