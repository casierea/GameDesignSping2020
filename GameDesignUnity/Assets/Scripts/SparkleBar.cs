using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SparkleBar : MonoBehaviour
{
    public Slider slider;


    public void SetMaxSparkle(float MaxSparkle)
    {
        Debug.Log(MaxSparkle);
        slider.maxValue = MaxSparkle;
        slider.minValue = 0.0f;
    }

    public void SetSparkle(float sparklehealth)
    {
        slider.value = sparklehealth;
        Debug.Log(sparklehealth);
    }

    //public void IncreaseSliderHealth()
    //{
    //floatdata healthup objects are added to player health script, which is reflected in the slider.
    //}
}
