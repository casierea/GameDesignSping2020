using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Random = UnityEngine.Random;


public class BossNav : MonoBehaviour
{
    //used in FixedUpdate
    public GameObject Player;
    public Boolean playerIsClose =false;

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

    public int thrusterSpeed;
    public int baseSpeed;
    public int thrusterTotal;
    public int speed;
    [SerializeField] private Vector3 target = new Vector3(1, 1, 1);
    //[SerializeField] private float speed = 1;
    

    // Start is called before the first frame update
    
    void Start()
    {
        //nav1 = new Vector3(144, 4, -27);
        //nav2 = new Vector3(75, 4, -27);
        //nav3 = new Vector3(75, 4, 46);
        //nav4 = new Vector3(144, 4, 46);
        navPoints.Add(nav1);
        navPoints.Add(nav2);
        navPoints.Add(nav3);
        navPoints.Add(nav4);

        thruster = GetComponent<Rigidbody>();
        //target = Player.GetComponent<Transform>().position;
        changeDestination();
    }

    void Update()
    {
        checkPlayerDistance();
        setDestination();
        thrusterCheck();
        moveTowards();
    }
    

    private void setDestination()
    {
        float destinationDistance = Vector3.Distance(target, this.GetComponent<Transform>().position);

        if (playerIsClose)
        {
            target = Player.GetComponent<Transform>().position;
        }
        
        else if (playerIsClose==false & destinationDistance < 1.5)
        {
            changeDestination();
        }
    }
    
    void changeDestination()
    {

        //Vector3 playerPos = Player.GetComponent<Transform>().position;
        //navPoints.Add(playerPos);
        // //
        int rand = Random.Range(0, navPoints.Count);
        target = navPoints[rand];
    }

    public void checkPlayerDistance()
    {
        var distanceToPlayer =
            Vector3.Distance(GetComponent<Transform>().position, Player.GetComponent<Transform>().position);

        if (distanceToPlayer <= Player.GetComponentInChildren<SphereCollider>().radius + 3)
        { 
            playerIsClose = true;
        }

        //remove drain and reset patrol destination if player is not close   
        if (distanceToPlayer > Player.GetComponentInChildren<SphereCollider>().radius + 10
        ) //light off radius should be .5
        {
            playerIsClose = false;
        }
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
