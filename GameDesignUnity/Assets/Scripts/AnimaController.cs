using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaController : MonoBehaviour
{
    public string animName = "walk";

    public void AnimCall(Animator animator)
    {
        animator.SetTrigger(name);
    }
}