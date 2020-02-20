using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour

{
    //change to FloatData
    public float maxHealth = 20f;
    //change to private in production
    public float currentHealth;
    public List<GameObject> LootTable;

    private GameObject droppedLoot; //this is the loot that is dropped in the dropLoot() function
    //public UnityEvent DeathEvent;
    //public UnityEvent DropLoot;
    //maybe put in a healthbar later to show robot health above their heads
    //public HealthBar healthBar;
    

    void Start()
    {
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        onZeroHealth();
    }

    public void ChangeHealth(float delta)
    {
        currentHealth += delta;
        //healthBar.SetHealth(currentHealth);
    }

    private void onZeroHealth ()
    {
        //convert to Scriptable Object Event
        //call death event
        if (currentHealth == 0)
        {
            //disable collider
            (gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = false;
            //destroy game object    
            Destroy(gameObject);
            dropLoot();
        }
        
    }

    private void dropLoot()
    {
        //convert to Scriptable Object or Unity Event call
        if (LootTable != null)
        {
            //instantiate loot from item destruction
            //check for existence of loot table
            //if loot table, then create loot   
            int rand = Random.Range(0, LootTable.Count);
            droppedLoot = LootTable[rand];
            Instantiate(droppedLoot, gameObject.GetComponent<Transform>().position, gameObject.GetComponent<Transform>().rotation);
        }
        
    }
    
}
