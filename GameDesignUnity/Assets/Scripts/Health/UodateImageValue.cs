using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Experimental.UIElements;


public class UodateImageValue : MonoBehaviour
{


    //public FloatData Data;
    public float Data;
    public FloatData PlayerSparkleTotal;
    private Image image;
    public GameObject Candle;

    //public FloatData MaxAmount;

    //public FloatData currentAmount;
    // Use this for initialization
    void Start ()
    {
        image = GetComponent<Image>();
    }
	
    // Update is called once per frame
    void Update ()
    {
        //Data = PlayerObject.GetComponent<ObjectHealth>().CurrentHealth;
        image.fillAmount = Candle.GetComponent<LightBehaviour>().lossRate;//Data;
    }
}
