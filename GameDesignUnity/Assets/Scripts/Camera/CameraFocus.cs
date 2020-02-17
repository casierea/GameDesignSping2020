using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour

//kaitlyns for understanding
{
    public Transform target;
    private void Update()
    {
        LookAt();
    }
 
    private void LookAt()
    {
        transform.LookAt(target);
    }
}