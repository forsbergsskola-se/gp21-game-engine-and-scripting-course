using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    //TODO Remove MovementApplier and return to applying velocities and forces directly in the walk and jump scripts?
    [SerializeField] private MovementApplier movementApplier;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float chargeTime = 1f;

    private float jumpCharge;

    private void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (commandContainer.jumpCommand)
            jumpCharge += Time.deltaTime / chargeTime;

        if (commandContainer.jumpCommandUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;

            if (groundChecker.IsGrounded)
                movementApplier.AddVelocity(Vector3.up * jumpForce);
        }
    }
}