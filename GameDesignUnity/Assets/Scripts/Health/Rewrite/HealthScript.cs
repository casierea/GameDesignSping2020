using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour

{

    public float maxHealth = 20f;
    public float currentHealth;

//maybe put in a healthbar later to show robot health above their heads
//public HealthBar healthBar;


    void Start()
    {
        currentHealth = maxHealth;
//healthBar.SetMaxHealth(maxHealth);
    }

    public void ChangeHealth(float delta)
    {
        currentHealth += delta;
//healthBar.SetHealth(currentHealth);
    }
}