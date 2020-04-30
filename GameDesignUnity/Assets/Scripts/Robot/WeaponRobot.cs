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
        // var otherHealth = other.GetComponent<PlayerHealth>();
        
        //Debug.Log("triggered robo sword");
        if (other.GetComponent<PlayerHealth>() != null)
        {
            other.GetComponent<PlayerHealth>().ChangeHealth(SwordDamage.Value);
            Debug.Log("doin the damage"+SwordDamage.Value);
        }

        // knock. retrigger collider when player touches robot again. Velocity to rigid body on the ontriggerenter
    }
}