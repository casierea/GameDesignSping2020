using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float Value = 1f;
    public float maxValue = 1f;
    public void UpdateValue(float amount)
    {
        Value += amount;
    }

    public void ChangeValue(float amount)
    {
        Value = amount;
    }
    public void UpdateValueLimitZero(float amount)
    {
        if (Value < 0)
        {
            Value = 0;
        }
        else
        {
            UpdateValue(amount);
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amount)
    {
        if (Value < maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            Value = maxValue;
        }
        UpdateValueLimitZero(amount);
    }
}