using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringListObj;

    public int currentLineNumber;

    //public GameObject buttonImage;

    private void Start()
    {
        currentLineNumber = 0; 
    }
    
    public string ReturnCurrentLine()   //being called constantly. being called by text obj.
    {
        //check if current line number >= max line count
        // if greater, delete object, don't do next return
        if (currentLineNumber <= stringListObj.Count)
        {
            return stringListObj[currentLineNumber];    
        }

        else 
        {

            return String.Empty;
       
        }  
    }

    public void LineNumber()  //being called by button. Part of original code
    {
        if (currentLineNumber < stringListObj.Count-1)
        {
            currentLineNumber++;
        }
        else 
        {
            //currentLineNumber = 0; This makes the string loop. 
        } 
    }
}
