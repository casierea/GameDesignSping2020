using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitOnSetTime : MonoBehaviour
{
    public UnityEvent TimeUpEvent;

    public float time;
    
    public void StartTimer()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        TimeUpEvent.Invoke();
    }
}
