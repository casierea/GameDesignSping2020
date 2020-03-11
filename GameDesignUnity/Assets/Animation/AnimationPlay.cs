using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    //Maybe for robot brick throws?

    [SerializeField] private Animator myAnimController;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimController.SetBool("hit", true);
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimController.SetBool("hit", false);
        }
        
    }
}
