using UnityEngine;

public class Forceful : MonoBehaviour
{
    public float Force = 1.0f;
    public Rigidbody RigBod;

    void Start()
    {
        RigBod = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RigBod.AddForce(transform.forward * Force);
    }
}