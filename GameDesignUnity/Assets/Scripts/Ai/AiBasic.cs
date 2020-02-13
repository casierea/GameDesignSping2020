using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(NavMeshAgent))]
public class AiBasic : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Player, destination;

    private void Start()
    {
        destination = Player;
        agent = GetComponent<NavMeshAgent>;
    }

    private void Update()
    {
        agent.destination = destination.Player;
        destination = Player;
    }
}
