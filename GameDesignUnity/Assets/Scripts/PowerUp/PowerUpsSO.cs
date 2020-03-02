using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PowSo : ScriptableObject
{
    public PowerUpStates.PowerStates PowerUp;

    public UnityEvent OneUp, StarSparkle, JumpBoots;
	
	
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
        switch (PowerUp)
        {
            case PowerUpStates.PowerStates.OneUp:
                break;
				
            case PowerUpStates.PowerStates.StarSparkle:
                break;
				
            case PowerUpStates.PowerStates.JumpBoots:
                break;
				
            
        }
		
    }
}