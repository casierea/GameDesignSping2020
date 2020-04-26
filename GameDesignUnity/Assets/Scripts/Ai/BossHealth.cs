using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealth : MonoBehaviour


{
    public float maxHealth = 200f;
    public float currentHealth;
    private GameObject droppedLoot; //this is the loot that is dropped in the dropLoot() function
    public GameObject enemyRobo;


    void Start()
    {
        currentHealth = maxHealth;
     
    }

    void Update()
    {
        onZeroHealth();
        
    }

    public void ChangeHealth(float delta)
    {
        currentHealth += delta;

        if (delta < 0)
        {
            spawnBot();
        }

    }

    private void onZeroHealth ()
    {

        if (currentHealth <= 0)
        {
            (gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = false;

           
            Destroy(gameObject);
            //dropLoot();
        }

    }


    private void spawnBot()
    {
        Instantiate(enemyRobo, gameObject.GetComponent<Transform>().position,
            gameObject.GetComponent<Transform>().rotation);
    }

}