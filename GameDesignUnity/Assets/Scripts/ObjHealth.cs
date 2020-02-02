using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RedoObjHealth : MonoBehaviour {

    public FloatData MaxHealth;
    public FloatData MinHealth;
    public FloatData StartHealth;
    public float CurrentHealth;
    public Sprite Dead01;
    public Sprite Dead02;
    private Transform barrier;
	
    public UnityEvent DeathEvent; 
    // Use this for initialization
    private void Start ()
    {
        CurrentHealth = StartHealth.Value;
    }

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

            if (Dead01)
            {
                gameObject.GetComponentInChildren<SpriteRenderer>().sprite = Dead01;
                StartCoroutine("ChangeDeathSprite");
            }

		
            if(gameObject.transform.childCount > 1)
            {
                barrier = gameObject.transform.GetChild(1);
                barrier.GetComponent<BoxCollider>().enabled = false;
            }

            gameObject.GetComponent<RedoObjHealth>().enabled = false;
            print("dying");
            DeathEvent.Invoke();
        }
		
    }

    IEnumerator ChangeDeathSprite()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = Dead02;
        yield return new WaitForSeconds(1.5f); // time before sprite disappears
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }	
}