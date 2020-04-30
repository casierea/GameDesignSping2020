using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour

{
//change to FloatData
    public float maxHealth = 300f;
//change to private in production
    public FloatData currentHealth;
    public List<GameObject> LootTable;
    
    private GameObject droppedLoot; //this is the loot that is dropped in the dropLoot() function
//public UnityEvent DeathEvent;
//public UnityEvent DropLoot;
    public UnityEvent DeathEvent; 

    public Slider healthBar;

    void Start()
    {
        currentHealth.Value = maxHealth;
        if (healthBar != null)
        {
            healthBar.GetComponent<HealthBar>().SetMaxHealth(maxHealth);
            healthBar.GetComponent<HealthBar>().SetHealth(currentHealth.Value);
        }
    }

    void Update()
    {
        healthBar.GetComponent<HealthBar>().SetHealth(currentHealth.Value);
        onZeroHealth();
        
    }

    public void ChangeHealth(float delta)
    {
        currentHealth.Value += delta;
        if (healthBar != null)
        {
            healthBar.GetComponent<HealthBar>().SetHealth(currentHealth.Value);
        }
        //healthBar.GetComponent<HealthBar>().SetHealth(currentHealth);
    }

    private void onZeroHealth ()
    {
//convert to Scriptable Object Event
//call death event
        if (currentHealth.Value == 0)
        {
//disable collider
            (gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = false;

            //Destroy(gameObject);
            
            gameObject.GetComponent<PlayerHealth>().enabled = false;
            print("dying");

            //new WaitForSeconds(2);
            
            DeathEvent.Invoke();
            
        }

        
    }

   

    //}

}