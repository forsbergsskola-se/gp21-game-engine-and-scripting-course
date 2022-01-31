using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    //TODO Remove MovementApplier and return to applying velocities and forces directly in the walk and jump scripts?
    [SerializeField] private MovementApplier movementApplier;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private float jumpForce = 500f;

    private void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (commandContainer.jumpCommandDown && groundChecker.IsGrounded)
            movementApplier.AddVelocity(Vector3.up * jumpForce);
    }
}