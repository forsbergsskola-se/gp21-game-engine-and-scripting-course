using System;
using UnityEngine;

public class MovementApplier : MonoBehaviour
{
    //TODO Remove MovementApplier and return to applying velocities and forces directly in the walk and jump scripts?

    [SerializeField] private Rigidbody myRigidbody;

    public Vector3 StoredVelocity => storedVelocity; //Lambda shorthand for a public getter, but with no setter. Could also be done as private setter, public getter.

    private Vector3 storedVelocity;
    private Vector3 storedForce;

    private void FixedUpdate()
    {
        ApplyVelocity();
        // ApplyForce();
    }

    private void ApplyVelocity()
    {
        myRigidbody.velocity = storedVelocity;
        storedVelocity = myRigidbody.velocity; //Could skip this if we want to.
    }

    // private void ApplyForce()
    // {
    //     myRigidbody.AddForce(storedForce);
    //     storedForce = Vector3.zero;
    //     // storedVelocity = myRigidbody.velocity;
    // }

    public void AddVelocity(Vector3 velocity)
    {
        storedVelocity += velocity;
    }

    public void SetHorizontalVelocity(float horizontalVelocity)
    {
        SetVelocity(new Vector3(horizontalVelocity, storedVelocity.y, storedVelocity.z));
    }

    public void SetVelocity(Vector3 velocity)
    {
        storedVelocity = velocity;
    }

    // public void AddForce(Vector3 force)
    // {
    //     storedForce += force;
    // }
}