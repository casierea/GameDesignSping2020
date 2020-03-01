using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Experimental.UIElements;


public class UpDateImageValue : MonoBehaviour
{


    //public FloatData Data;
    public float Data;
    public FloatData MaxHealth;
    private Image image;
    public GameObject PlayerObject;
	
    // Use this for initialization
    void Start ()
    {
        image = GetComponent<Image>();
    }
	
    // Update is called once per frame
    void Update ()
    {
        //Data = PlayerObject.GetComponent<ObjectHealth>().CurrentHealth;
        image.fillAmount = PlayerObject.GetComponent<PlayerHealthScript>().CurrentHealth / MaxHealth.Value;//Data;
    }
}
