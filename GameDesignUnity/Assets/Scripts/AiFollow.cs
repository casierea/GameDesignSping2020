using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player, destination;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        agent.destination = destination.position;
        
    }

    public void SawPlayer()
    {
        destination = player;
    }

    public void LostPlayer()
    {
        destination = null;
    }
}