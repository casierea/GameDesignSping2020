using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REnemyFire : MonoBehaviour

{
    public Transform WeaponPosition;
    public GameObject EnemyShoot;
    public FloatData BulletSpeed;
    private float ShootyForce;
    private bool FacingLeft;
    private bool readyToFire = true;
	
    //private void Update()
    //{
    // FacingRight = gameObject.GetComponentInParent<SpriteRenderer>().flipX;
    //}

    private void OnTriggerStay(Collider other)
    {	//Debug.Log("Player tag");
		
        if (other.tag == "Player" & readyToFire)
        {	
            Invoke("BeginShoot", 0.5f); 
            //Debug.Log("After begin Shoot" + readyToFire);
            StartCoroutine(ShootDelay(1.0f));
            //Debug.Log("After begin Delay" + readyToFire);
        }
    }

    private IEnumerator ShootDelay(float waitTime)
    {
        readyToFire = false;
        yield return new WaitForSeconds(waitTime);
        readyToFire = true; 
        //Debug.Log("After ready set true" + readyToFire);
    }

    void BeginShoot()
    {
		
        if (FacingLeft == true)
        {
            ShootyForce = -BulletSpeed.Value;
        }
        else
        {
            ShootyForce = BulletSpeed.Value;
        }
        GameObject Clone;
        Clone = Instantiate(EnemyShoot, WeaponPosition.position, transform.rotation);
        Clone.GetComponent<Rigidbody>().AddForce(ShootyForce,0,0);
		
    }
		

}