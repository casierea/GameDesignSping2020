using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextBehaviour : MonoBehaviour
{
    private Text textObj;

    public StringListData stringListDataObj;

//awake is before start.
    void Awake()
    {
        textObj = GetComponent<Text>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //replace update with an event system   
        textObj.text = stringListDataObj.ReturnCurrentLine(); // this will constantly spit out current numbers. We like how short it is.
        
     
    }
}
