using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    public FloatData SparkleTotal;
    public int lossRate = 5;
    private Boolean lightStatus = false;

    private void Update()
    {
        this.GetComponent<Light>().enabled = lightStatus;


        if (lightStatus)
        {
            this.GetComponent<Light>().intensity = SparkleTotal.Value;
            this.GetComponent<Light>().range = SparkleTotal.Value / 10;
            this.GetComponent<SphereCollider>().radius = SparkleTotal.Value / 10;
        }
        else
        {
            this.GetComponent<SphereCollider>().radius = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightSwitch();
        }

        if (lightStatus == true)
        {
            SparkleTotal.Value -= lossRate * Time.deltaTime;
        }
    }
    private void lightSwitch()
    {
        if (SparkleTotal.Value > 0)
        {
            lightStatus = !lightStatus;
            this.GetComponent<Light>().enabled = lightStatus;    
        }
        else
        {
            lightStatus = false;
        }
    }


}