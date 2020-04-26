using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class AnimaController : MonoBehaviour
{
    //public string animName = "walk";

    public GameObject thePlayer;


    private void Update()
    {
        //if (Input.GetMouseButtonDown(1))
            //Debug.Log("Pressed secondary button.");
        if (Input.GetButtonDown("enter"))
        
            thePlayer.GetComponent<Animator>().Play("Swing");
        }
    }

    //public void AnimCall(Animator animator)
    //{
    //    animator.SetTrigger(name);
    //}
//THISONEWORKS
