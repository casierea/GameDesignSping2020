using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
        //calculate and keep the offset value by getting the distance between the camera and player
    }

    private void LateUpdate() //called after each update frame
    {
        transform.position = player.transform.position + offset;
        //the cameras transform will now be the same as the players, but offset by the offset distance above
    }
}