using System.Collections;
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
        /*if (Input.GetKeyDown("p"))
        {
            //anim2.Play("AnimaSwing");
            anim2.Play("EmptSwingAnim");
        }*/
        
        /*if (Input.GetKeyDown("i"))
        {
            //anim2.Play("AnimaSwing");
            anim2.Play("Berserker");
        }*/

        /*if (Input.GetMouseButtonDown(0))
        {
            anim2.Play("EmptSwingAnim");
        }*/
        
        if (Input.GetMouseButtonDown(1))
        {
           anim2.Play("EmptSwingAnim");
        }
    }
}
