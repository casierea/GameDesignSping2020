using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringListObj;

    public int currentLineNumber;
    //whatever this is in the editot, it will calll that line

    public string ReturnCurrentLine()   //being called constantly. being called by text obj.
    {
        return stringListObj[currentLineNumber];
    }

    public void LineNumber()  //being called by button
    {
        if (currentLineNumber < stringListObj.Count-1)
        {
            currentLineNumber++;
        }
        else
        {
            currentLineNumber = 0;
        }
        
    }
}
