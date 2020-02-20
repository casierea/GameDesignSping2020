using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterme : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    public UnityEvent Enable;
    public UnityEvent Trigger;

    void OnEnable()
    {
        //Enable.Invoke();
        Debug.Log("Enable");
    }

    private void OnTriggerEnter(Collider other)
    {
        Trigger.Invoke();
        Debug.Log("Enter");
    }
}
