using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOnTrigger : MonoBehaviour {

    public FloatData Heal;
	
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ObjHealth>())
        {
            other.GetComponent<ObjHealth>().HealHealth(Heal.Value);
        }

        if (other.gameObject.GetComponent<MultiObjHealth>())
        {
            other.GetComponent<MultiObjHealth>().HealHealth(Heal.Value);
        }
    }
}