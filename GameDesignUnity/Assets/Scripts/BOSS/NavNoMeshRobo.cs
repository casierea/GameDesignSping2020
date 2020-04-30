using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class NavNoMeshRobo : MonoBehaviour
{
    public Vector3 nav1;
    public Vector3 nav2;
    public Vector3 nav3;
    public Vector3 nav4;
    List<Vector3> navPoints = new List<Vector3>(); // empty now

    public GameObject Player;
    public Boolean playerIsClose;
    
    [SerializeField] private Vector3 target = new Vector3(1, 1, 1);
    [SerializeField] private float speed = 4;

    void Start()
    {
        nav1 = new Vector3(-22, 62.5f, 347);
        nav2 = new Vector3(-22, 62.5f, 304.6f);
        nav3 = new Vector3(50, 62.5f, 304.6f);
        nav4 = new Vector3(50, 62.5f, 313.7f);
        
        navPoints.Add(nav1);
        navPoints.Add(nav2);
        navPoints.Add(nav3);
        navPoints.Add(nav4);

        target = Player.GetComponent<Transform>().position;

    }

    void Update()
    {
        checkPlayerDistance();
        setDestination();
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
}