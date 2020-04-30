using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class updateValue : ScriptableObject

{
    public FloatData DeltaValue;
    public GameObject targetObject;
    public FloatData ValueStore;
    
    
    
    
    public void ChangeTargetValue(FloatData targetData)
    {
        targetData.Value += DeltaValue.Value;
        if (ValueStore!= null & targetData.Value > ValueStore.maxValue)
        {
            targetData.Value = ValueStore.maxValue;
        }
    }

}