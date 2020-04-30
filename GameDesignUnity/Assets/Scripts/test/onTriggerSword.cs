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
        //Debug.Log("Enable");
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherHealth = other.GetComponent<OtherHealth>();
        var bossHealth = other.GetComponent<BossHealth>();
        var thrusterHealth = other.GetComponent<thrusterHealth>();
        if (otherHealth != null)
        {
            //Trigger.Invoke();
            otherHealth.ChangeHealth(SwordDamage.Value);
            //Debug.Log("trigger entered SWORRRDD");    
        }

        if (bossHealth != null)
        {
            bossHealth.ChangeHealth(SwordDamage.Value);
        }
        if (thrusterHealth != null)
        {
            thrusterHealth.ChangeHealth(SwordDamage.Value);
        }

        
        
    }
}