using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    public Boolean lightStatus = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightSwitch();
        }
    }
    private void lightSwitch()
    {
        lightStatus = !lightStatus;
        this.GetComponent<Light>().enabled = lightStatus;
    }
}