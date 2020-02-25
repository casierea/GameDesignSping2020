using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class TriggerEvents : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    public UnityEvent triggerEnterEvent, triggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        Debug.Log("Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
        Debug.Log("Exit");
    }


    // public UnityEvent TriggerEnterCollide;

    // private void OnTriggerEnter(Collider other)
    // {
    //   TriggerEnterCollide.Invoke();
    //   Debug.Log("Trigger Collided");
    //}
}