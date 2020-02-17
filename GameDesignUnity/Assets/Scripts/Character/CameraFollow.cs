using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

//Kaitlyns for undertsanding

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 cameraOffset;
    
    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.5f;

    private void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }
    
    private void LateUpdate()
    {
        Vector3 newPos = playerTransform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}