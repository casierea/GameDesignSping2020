using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System;

public class RoboLightBehav : MonoBehaviour
{
    public FloatData SparkleTotal;
    public int lossRate = 0;
    private Boolean lightStatus = true;

    private void Start()
    {
        SparkleTotal.Value = SparkleTotal.maxValue;
    }
    private void Update()
    {
        this.GetComponent<Light>().enabled = lightStatus;
        this.GetComponent<Light>().intensity = SparkleTotal.Value;
        this.GetComponent<Light>().range = SparkleTotal.Value / 10;
        
        if (lightStatus == true & SparkleTotal.Value > 0)
        {
            SparkleTotal.Value -= lossRate * Time.deltaTime;
        }
        else if (SparkleTotal.Value <= 0)
        {
            lightStatus = false;
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