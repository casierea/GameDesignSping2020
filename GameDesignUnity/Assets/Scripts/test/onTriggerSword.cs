using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onTriggerSword : MonoBehaviour
{
    public FloatData SwordDamage;
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
        var otherHealth = other.GetComponent<healthScript>();
        if (otherHealth == null)
        {
            Debug.Log("no health module on other");
            //abandon all hope
        }
        else
        {
            //Trigger.Invoke();
            otherHealth.ChangeHealth(SwordDamage.Value);
            Debug.Log("trigger entered SWORRRDD");    
        }
        
    }
}
