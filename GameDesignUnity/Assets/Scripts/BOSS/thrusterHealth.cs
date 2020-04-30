using UnityEngine;

public class thrusterHealth : MonoBehaviour


{
    public float maxHealth = 20f;
    public float currentHealth;



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

    }

    private void onZeroHealth()
    {

        if (currentHealth <= 0)
        {
            (gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = false;
            Destroy(gameObject);
            // gameObject.GetComponentInParent<BossNav>().thruster1;
        }

    }


}