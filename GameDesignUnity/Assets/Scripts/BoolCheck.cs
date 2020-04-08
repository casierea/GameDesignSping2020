using UnityEngine;
using UnityEngine.Events;

public class BoolCheck : MonoBehaviour
{
    public FloatData Inventory;
    public float check;
    public UnityEvent Open;
    public UnityEvent Warning;

    public void CheckForItem ()
    {
        if (Inventory.Value >= check)
        {
            Open.Invoke();
        }

        else
        {
            Warning.Invoke();
        }
    }

}