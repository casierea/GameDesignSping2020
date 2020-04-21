using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Eyes : MonoBehaviour
{
    public GameObject Enemy;


    void OnTriggerEnter(Collider other)
    {
        //if(other.tag == "Player")
           // Enemy.GetComponent<AiFollow>().SawPlayer();
    }

    void OnTriggerExit(Collider other)
    {
       // if(other.tag == "Player")
           // Enemy.GetComponent<AiFollow>().LostPlayer();
    }
}