﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSetTrigger : MonoBehaviour
{
    public string animName;

    public Animator anim;

    private void Set()
    {
        anim.SetTrigger(animName);
    }
}