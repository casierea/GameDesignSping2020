using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour

{
//change to FloatData
    public float maxHealth = 100f;
//change to private in production
    public FloatData currentHealth;
    public List<GameObject> LootTable;
    
    private GameObject droppedLoot; //this is the loot that is dropped in the dropLoot() function
//public UnityEvent DeathEvent;
//public UnityEvent DropLoot;


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
        //healthBar.GetComponent<HealthBar>().SetHealth(currentHealth.Value);
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
//destroy game object
            Destroy(gameObject);
            //DeathEvent.invoke();
            //dropLoot();
        }

        
    }

    //public void HealHealth(float heal)
    //{
        //if (currentHealth < maxHealth)
        //{
        //    currentHealth += heal;
        //}
   // }
   // private void dropLoot()
   // {
//convert to Scriptable Object or Unity Event call
       // if (LootTable.Count > 0)
        //{
//instantiate loot from item destruction
//check for existence of loot table
//if loot table, then create loot
           // int rand = Random.Range(0, LootTable.Count);
            //droppedLoot = LootTable[rand];
            //Instantiate(droppedLoot, gameObject.GetComponent<Transform>().position, gameObject.GetComponent<Transform>().rotation);
        //}

    //}

}