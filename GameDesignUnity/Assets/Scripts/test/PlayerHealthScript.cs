using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public FloatData MaxHealth;

    public FloatData MinHealth;

    public FloatData StartHealth;

    public float CurrentHealth;

    // Start is called before the first frame update
    private void Start()
    {
        CurrentHealth = StartHealth.Value;
    }

    // Update is called once per frame
    private void Update()
    {
        ZeroHealth();
    }

    public void DamageHealth(float damage)
    {
        if (CurrentHealth > MinHealth.Value)
        {
            CurrentHealth -= damage;
        }
    }

    public void HealHealth(float heal)
    {
        if (CurrentHealth < MaxHealth.Value)
        {
            CurrentHealth += heal;
        }
    }

    public void ZeroHealth()
    {
        if (CurrentHealth <= MinHealth.Value)
        {
            //die
            gameObject.GetComponent<BoxCollider>().enabled = false;

            if (gameObject.GetComponent<CharacterController>())
            {
                gameObject.GetComponent<CharacterController>().enabled = false;
            }

            if (gameObject.GetComponent<Rigidbody>() != null)
            {
                gameObject.GetComponent<Rigidbody>().freezeRotation = false;

                gameObject.GetComponent<Rigidbody>().useGravity = false; // stop dead sprites from falling

            }
        }
    }
}
