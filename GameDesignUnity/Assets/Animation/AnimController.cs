﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator anim2;

    private void Start()
    {

        anim2 = GetComponent<Animator>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown("enter"))
        {
            //anim2.Play("AnimaSwing");
            anim2.Play("EmptSwingAnim");
        }
    }
}