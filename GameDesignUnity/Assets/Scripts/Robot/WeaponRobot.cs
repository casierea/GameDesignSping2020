using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponRobot : MonoBehaviour
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
        //Debug.Log("Enable");
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherHealth = other.GetComponent<PlayerHealth>();
        if (otherHealth == null)
        {
            //Debug.Log("no health module on other");
            //abandon all hope
        }
        else
        {
            //Trigger.Invoke();
            otherHealth.ChangeHealth(SwordDamage.Value);
            //Debug.Log("trigger entered BEEP");    
        }
        
        // knock. retrigger collider when player touches robot again. Velocity to rigid body on the ontriggerenter
    }
}
