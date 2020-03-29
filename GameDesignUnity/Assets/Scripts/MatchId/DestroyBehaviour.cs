using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;

    public void DestroyObj()
    {
        startEvent.Invoke();
    }
}
