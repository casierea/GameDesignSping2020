using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DropItem : MonoBehaviour
{
   public bool dropGameObj = false;

   public UnityEvent DropObjEvent;
   
   private void Update()
   {
     // while (dropGameObj = true)
      //{
      //   DropObjEvent.Invoke();
      //}
   }
}
