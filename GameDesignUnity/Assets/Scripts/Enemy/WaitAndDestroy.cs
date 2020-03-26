using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitAndDestroy : MonoBehaviour
{
    public float bulletLastsSeconds = 3;
    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(bulletLastsSeconds);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        //Destroy(other.gameObject); 
	
        Destroy(gameObject);
		
        // makes bullets collide and destory eachother
    }
}