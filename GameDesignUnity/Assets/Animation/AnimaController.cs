using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaController : MonoBehaviour
{
    //public string animName = "walk";

    public GameObject thePlayer;


    private void Update()
    {
        if (Input.GetButtonDown("enter"))
        {
            thePlayer.GetComponent<Animator>().Play("Swing");
        }
    }

    //public void AnimCall(Animator animator)
    //{
    //    animator.SetTrigger(name);
    //}
}