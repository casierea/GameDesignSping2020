

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;


public class EnemyPatrolAi : MonoBehaviour
{
    public List<Vector3Data> PatrolPoints;
    public GameObject Player;
    public GameObject Candle;
    public Boolean playerIsClose = false;
    public int CurrentDestination = 0;
    public Boolean DrainOn = false;
    public Vector3 destination;
    private NavMeshAgent agent;
    
    private void Start()
    {
        
        
        agent = GetComponent<NavMeshAgent>();
        destination = PatrolPoints[CurrentDestination].Value;
    }
    
    private void Update() //reorder maybe
    {
        agent.destination = destination;
        checkPlayerDistance();
        setDestination();
        
    }

    private void setDestination()
    {
        float destinationDistance = Vector3.Distance(destination, this.GetComponent<Transform>().position);

        if (playerIsClose)
        {
            destination = Player.GetComponent<Transform>().position;
        }


        else if (playerIsClose==false & destinationDistance < 1.5)
        {
            
           // Debug.Log(CurrentDestination+ "destination counter");
            if (CurrentDestination < PatrolPoints.Count -1)
            {
                CurrentDestination += 1;    
            }
            else
            {
                CurrentDestination = 0;
            }
            //Debug.Log(CurrentDestination+ " destination counter " + PatrolPoints.Count);
            destination = PatrolPoints[CurrentDestination].Value;
        }
    }

    public void checkPlayerDistance()
    {
        var distanceToPlayer =
            Vector3.Distance(GetComponent<Transform>().position, Player.GetComponent<Transform>().position);
        //Debug.Log(other.tag);
        //Debug.Log(other);
        
        //add drain and target player if player is close
        //Debug.Log(distanceToPlayer+ " player distance");
        if (distanceToPlayer <= Player.GetComponentInChildren<SphereCollider>().radius + 3)
        {

            playerIsClose = true;
            //destination = Player.GetComponent<Transform>().position;
            //Debug.Log("player close " + distanceToPlayer + " " +
                      //Player.GetComponentInChildren<SphereCollider>().radius);
            if (DrainOn == false)
            {
                //Debug.Log("adding draning");
                Player.GetComponentInChildren<LightBehaviour>().lossRate += 1;
                this.GetComponentInChildren<RoboLightBehav>().lossRate -= 1;
                DrainOn = true;
            }
        }

        //remove drain and reset patrol destination if player is not close   
        if (distanceToPlayer > Player.GetComponentInChildren<SphereCollider>().radius + 10) //light off radius should be .5
        {
            playerIsClose = false;
            //destination = PatrolPoints[CurrentDestination].Value;
            if (DrainOn == true)
            {
                //Debug.Log("removing drain");
                Player.GetComponentInChildren<LightBehaviour>().lossRate -= 1;
                this.GetComponentInChildren <RoboLightBehav>().lossRate += 1;
                DrainOn = false;

            }
           // Debug.Log("player NOT close "+ distanceToPlayer+" " + Player.GetComponentInChildren<SphereCollider>().radius);
        }

        
    }
    /*
    public void playerClose(GameObject other)
    {
        var distanceToPlayer =
            Vector3.Distance(GetComponent<Transform>().position, Player.GetComponent<Transform>().position);
        
        if (other.tag == "Player" &
            distanceToPlayer <= Player.GetComponentInChildren<SphereCollider>().radius + 5)
        {
            
            playerIsClose = true;
            Debug.Log(distanceToPlayer+ "player distance");
            if (DrainOn == false)
            {
                //Debug.Log("adding draning");
                Player.GetComponentInChildren<LightBehaviour>().lossRate += 1;
                this.GetComponentInChildren<RoboLightBehav>().lossRate -= 1;
                DrainOn = true;
            }

        }
        
    }
    public void playerNotClose(GameObject other)
    {
        var distanceToPlayer =
            Vector3.Distance(GetComponent<Transform>().position, Player.GetComponent<Transform>().position);
        if (other.tag == "Player" & 
            distanceToPlayer > Player.GetComponentInChildren<SphereCollider>().radius + 10)
        {
            playerIsClose = false;
            //destination = PatrolPoints[CurrentDestination].Value;
            if (DrainOn == true)
            {
                Debug.Log("removing drain");
                Player.GetComponentInChildren<LightBehaviour>().lossRate -= 1;
                this.GetComponentInChildren <RoboLightBehav>().lossRate += 1;
                DrainOn = false;

            }
            Debug.Log("player NOT close poop "+ distanceToPlayer);
        }
    }
*/

}
