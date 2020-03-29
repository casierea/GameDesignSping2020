using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DestroyIt : MonoBehaviour
{
  public UnityEvent BeforeDestroyEvent;
  public UnityEvent AfterDestroyEvent;
    public Button button;

  public void DestroyThis()
  {
    BeforeDestroyEvent.Invoke();
    //Destroy(button);
    Destroy(button.gameObject);
    Destroy(gameObject);
    
    Debug.Log("BeforeDestroy");
    
    
    AfterDestroyEvent.Invoke();
    gameObject.SetActive(true);
    
    
  }
}
