using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class StateMachine : MonoBehaviour{
    public string GameState;
    public UnityEvent Starting, Playing, Ending, Dying, Winning;
	
//StateMachine.Can do a unityevent.
	
// Use this for initialization
    void Start ()
    {
        Run();
    }

    public void ChangeState(string NewState)
    {
        GameState = NewState;
        Run();
    }
	
// Update is called once per frame
    public void Run () {
        switch (GameState)
        {
            case "Starting":
                Starting.Invoke();
                break;
						
            case "Dying":
                Dying.Invoke();
                break;
						
            case "Playing":
		  
                Playing.Invoke();
                break;
						
            case "Ending":
                Ending.Invoke();
                break;
					
            case "Winning":
                Winning.Invoke();
                break;
        }
    }
}


