using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        //Set move velocity
        //Preferably interact with physics in FixedUpdate() 
        myRigidbody.velocity = new Vector3(playerInputController.MoveInput * moveSpeed, myRigidbody.velocity.y, 0);
    }
}