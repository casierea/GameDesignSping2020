using UnityEngine;

[CreateAssetMenu]

public class PowerUpSO : ScriptableObject
{
    public FloatData Data;
    
    public void OnPowerUp(FloatData outsideData)
    {
        outsideData.Value += Data.Value;
    }
}
