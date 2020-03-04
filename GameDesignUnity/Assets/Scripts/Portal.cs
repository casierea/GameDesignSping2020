using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject TeleportLocation;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<CharacterController>().enabled = false; //run in and turn off control.
        other.gameObject.transform.position = TeleportLocation.transform.localPosition;
        other.GetComponent<CharacterController>().enabled = true; //turn back on
        
    }
}
