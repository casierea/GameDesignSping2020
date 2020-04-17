using UnityEngine;
using UnityEngine.Events;

public class BoolCheck : MonoBehaviour
{
    public FloatData Inventory;
    public float check;
    public UnityEvent Open;
    public UnityEvent Warning;


    private void Start()
    {
        
    }

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