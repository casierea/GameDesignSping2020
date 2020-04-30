using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class LightBehaviour : MonoBehaviour
{
    public FloatData SparkleTotal;
    public float StartSparkleVal = 100f;
    public int lossRate = 1;
    public Boolean lightStatus = false;
    public Slider SparkleBar;

    public float minValue = 0f;
    
    private void Start()
    {
        
        {
            SparkleTotal.Value = SparkleTotal.maxValue;   //took off of robot light behaviour and put here
        }
        
        if (SparkleBar != null)
        {
            SparkleTotal.Value = StartSparkleVal;
            SparkleBar.GetComponent<SparkleBar>().SetMaxSparkle(SparkleTotal.maxValue);
            SparkleBar.GetComponent<SparkleBar>().SetSparkle(SparkleTotal.Value);
            
        }
    }
    private void Update()
    {
        this.GetComponent<Light>().enabled = lightStatus;


        if (lightStatus)
        {
            this.GetComponent<Light>().range = SparkleTotal.Value;
            this.GetComponent<Light>().intensity = SparkleTotal.Value /50;
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

        if (lightStatus == true && SparkleTotal.Value > minValue)
        {
            SparkleTotal.Value -= lossRate * Time.deltaTime;
            
        }
        if (SparkleBar != null)
        {
            SparkleBar.GetComponent<SparkleBar>().SetSparkle(SparkleTotal.Value);
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