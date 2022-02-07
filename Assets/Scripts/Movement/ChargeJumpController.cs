using UnityEngine;
using UnityEngine.Events;

public class ChargeJumpController : MonoBehaviour
{
    //TODO Remove MovementApplier and return to applying velocities and forces directly in the walk and jump scripts?
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float chargeTime = 1f;
    [SerializeField] private UnityEvent<float> onChargeJump;

    private float jumpCharge;

    private void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (commandContainer.jumpCommand)
        {
            jumpCharge += Time.deltaTime / chargeTime;
            jumpCharge = Mathf.Clamp01(jumpCharge); //Clamp jumpCharge so it's always within a 0-1 range.
        }

        if (commandContainer.jumpCommandUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);

            if (groundChecker.IsGrounded)
            {
                myRigidbody.AddForce(Vector3.up * jumpForce);
                onChargeJump.Invoke(jumpCharge);
            }

            jumpCharge = 0f;
        }
    }
}