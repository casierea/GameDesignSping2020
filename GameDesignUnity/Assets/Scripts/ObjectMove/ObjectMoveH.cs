using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveH : MonoBehaviour
{

    public int BlockSpeed = 4;

    public int XMoveDirection = -1;

    //public Vector3Data Destination1;

    //public Vector3Data Destination2;

    public Vector3 Destination1 = new Vector3(0, 0 ,0);
    public Vector3 Destination2;
    
    public List<Vector3Data> PatrolPoints = new List<Vector3Data>();

    private Vector3 CurrentDestination;
	
    // Use this for initialization
    void Start ()
    {
        // PatrolPoints.Add(Destination1);
        // PatrolPoints.Add(Destination2);
        //CurrentDestination = Destination1.Value;
        CurrentDestination = Destination1;
    }
	
    // Update is called once per frame
    void Update ()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(XMoveDirection, 0) * BlockSpeed;
        switchDestination();
		
    }

    private void switchDestination()
    {
        if (Vector3.Distance(transform.position, CurrentDestination) < 2.0f)
        {
            Flip();

            if (CurrentDestination == Destination1)
            {
                CurrentDestination = Destination2;
            }
            else if (CurrentDestination == Destination2)
            {
                CurrentDestination = Destination1;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Flip();
        if (CurrentDestination == Destination1)
        {
            CurrentDestination = Destination2;
        }
        else if (CurrentDestination == Destination2)

        {
            CurrentDestination = Destination1;
        }
    }

    private void Flip()
    {
        XMoveDirection *= -1;
    }
}
