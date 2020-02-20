using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class valueManager : MonoBehaviour
{
    public FloatData SparkleTotal;

    public void ChangeSparkleTotal(float delta)
    {
        SparkleTotal.Value += delta;
    }
    
    
}
