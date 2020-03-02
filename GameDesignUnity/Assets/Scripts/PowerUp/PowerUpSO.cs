using UnityEngine;

[CreateAssetMenu]

public class PowerUpSO : ScriptableObject
{
    public FloatDataValue Data;
    
    public void OnPowerUp(FloatDataValue outsideData)
    {
        Debug.Log(outsideData.Value);
        
        outsideData.Value += Data.Value;
    }
}
