using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private float jumpForce = 500f;

    private void Update()
    {
        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (playerInputController.JumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);
    }
}