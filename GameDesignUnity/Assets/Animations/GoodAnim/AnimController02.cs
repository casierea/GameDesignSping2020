using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class AnimController02 : MonoBehaviour
{
    //public string animName = "walk";

    public GameObject thePlayer;


    private void Update()
    {
        if (Input.GetButtonDown("o"))
        
            thePlayer.GetComponent<Animator>().Play("Swing");
    }
}


