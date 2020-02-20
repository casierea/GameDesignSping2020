using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.Events;
public class lootPickup : MonoBehaviour
{
    public UnityEvent Enable;
    public UnityEvent Trigger;

    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }
    
    void OnEnable()
    {
        //Enable.Invoke(); //enable animation event here
        Debug.Log("Enable");
    }

    private void OnTriggerEnter(Collider other)
    {

        //destroy loot object on pickup
        //give powerup (starsparkle points)
        //Trigger.Invoke(); 
        Debug.Log("Sparkle Entered");
        Destroy(gameObject);//remove the lootObject
        
    }
}
