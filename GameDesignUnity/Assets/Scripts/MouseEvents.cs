

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent MouseDownEvent, MouseUpEvent, MouseDragEvent;
 

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        MouseUpEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        MouseDragEvent.Invoke();
    }
}




















































































