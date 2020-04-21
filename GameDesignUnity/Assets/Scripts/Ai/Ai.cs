using System;
using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Ai : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform destinationObj;
    private Transform currentDestinationObj;
    public float restartTime = 3f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentDestinationObj = destinationObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestinationObj = transform;
        Invoke(nameof(RestartAI), restartTime);
    }

    private void RestartAI()
    {   
        currentDestinationObj = destinationObj;
    }

    void Update()
    {
        agent.destination = currentDestinationObj.position;
    }
}