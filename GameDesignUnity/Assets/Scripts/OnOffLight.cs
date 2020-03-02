using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffLight : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            this.GetComponent<Light>().enabled = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.GetComponent<Light>().enabled = false;
        }
    }
}
