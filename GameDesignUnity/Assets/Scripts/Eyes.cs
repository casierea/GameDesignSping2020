using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Eyes : MonoBehaviour
{
    public GameObject Enemy;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            Enemy.GetComponent<AiFollow>().SawPlayer();
        Debug.Log("Saw Player");
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
            Enemy.GetComponent<AiFollow>().LostPlayer();
        Debug.Log("LostPlayer");
    }
}