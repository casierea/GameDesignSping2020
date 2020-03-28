using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class valueManager : MonoBehaviour
{
    public FloatData SparkleTotal;
    //public FloatData maxSparkle;
    //public FloatData currentSparkle;
    
    public Slider SparkleBar;


    void Start()
    {
        //SparkleTotal.Value = SparkleTotal.maxValue;
        if (SparkleBar != null)
        {
            //SparkleBar.GetComponent<SparkleBar>().SetMaxSparkle(SparkleTotal.maxValue);
            //SparkleBar.GetComponent<SparkleBar>().SetSparkle(SparkleTotal.Value);
        }
    }
    
    public void ChangeSparkleTotal(float delta)
    {
       // currentSparkle.Value += delta;
        SparkleTotal.Value += delta;
        
        if (SparkleBar != null)
        {
            SparkleBar.GetComponent<SparkleBar>().SetSparkle(SparkleTotal.Value);
        }
        //healthBar.GetComponent<HealthBar>().SetHealth(currentHealth);
    }
    
    //public void ChangeSparkleTotal(float delta)
    //{
    //    SparkleTotal.Value += delta; try this next
    
    //}
    
    //new stuff
   

}