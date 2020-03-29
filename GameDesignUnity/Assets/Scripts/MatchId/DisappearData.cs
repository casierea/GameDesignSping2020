using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DisappearData : NameId
{
    public GameObject Obj;
    
    public void Disappear()
    {
        Destroy(Obj);
        Debug.Log("destroy");
    }
}
