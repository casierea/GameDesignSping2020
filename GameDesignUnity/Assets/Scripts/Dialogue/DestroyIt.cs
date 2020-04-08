using UnityEngine;
using UnityEngine.Events;

public class DestroyIt : MonoBehaviour
{
    public UnityEvent BeforeDestroyEvent;
    public UnityEvent AfterDestoryEvent;

    public void DestroyThis ()
    {
        BeforeDestroyEvent.Invoke();
        Destroy(gameObject);

        AfterDestoryEvent.Invoke();
        gameObject.SetActive(true);
    }
}