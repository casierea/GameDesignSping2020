using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class StringObj : ScriptableObject
{
    public List<string> stringy;
    public float time; 

 public float objLastsTime = 3;
    public ScriptableObject gameObject;
    
 IEnumerator Start()
 {
  yield return new WaitForSeconds(objLastsTime);
  Destroy(gameObject);
 }
}




