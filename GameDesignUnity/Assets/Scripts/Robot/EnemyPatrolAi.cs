
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
    
    public Vector3 destination;
    private NavMeshAgent agent;
    
    private void Start()
    {
        destination = PatrolPoints[CurrentDestination].Value;
        
        agent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        agent.destination = destination;
        setDestination();
    }

    private void setDestination()
    {
        float destinationDistance = Vector3.Distance(destination, this.GetComponent<Transform>().position);

        if (playerIsClose)
        {
            destination = Player.GetComponent<Transform>().position;
        }


        else if (destinationDistance < 1.5)
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

    public void playerClose(GameObject other)
    {
        //Debug.Log(other.tag);
        //Debug.Log(other);
        
        //if (other.tag == "Enemy")
        if (other.tag == "Player")
        {
            
            playerIsClose = true;
            destination = Player.GetComponent<Transform>().position;
            Player.GetComponentInChildren<LightBehaviour>().lossRate += 1;
            this.GetComponentInChildren<RoboLightBehav>().lossRate -= 1;
            //Debug.Log(destination);    
            Debug.Log("PLayer close");

        }
        
    }
    public void playerNotClose(GameObject other)
    {
        if (other.tag == "Player")
        {
            playerIsClose = false;
            destination = PatrolPoints[CurrentDestination].Value;
            Player.GetComponentInChildren<LightBehaviour>().lossRate -= 1;
            this.GetComponentInChildren <RoboLightBehav>().lossRate += 1;
            Debug.Log("player NOT close ");
        }
    }

   public IEnumerator PauseNavigation()
    {
        yield return new WaitForSeconds(3);     
        
    }
  
}

	
	
	
