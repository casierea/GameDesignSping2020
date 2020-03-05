using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGameObject : MonoBehaviour
{
    public GameObject spawnObj;
    public Transform spawnLocation;
    public float time;
    public void InstantiateObject()
    {
        //Instantiate(spawnObj, spawnLocation.position, spawnLocation.rotation);
        Instantiate(spawnObj,spawnLocation.transform.position,Quaternion.identity);
    }

    IEnumerator InstatiateWithWait()
    {
        yield return new WaitForSeconds(time);
        InstantiateObject();
    }

    public void DelayedInstantiate()
    {
        InstatiateWithWait();
    }
}
