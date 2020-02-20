using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    public UnityEvent EnableEvent;
    public UnityEvent EnterEvent;
    public UnityEvent ExitEvent;

    void OnEnable()
    {
        //Enable.Invoke();
        Debug.Log("Enable");
    }

    private void OnTriggerEnter(Collider other)
    {
        EnterEvent.Invoke();
        Debug.Log("Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitEvent.Invoke();
        //Destroy(gameObject);
    }
}
