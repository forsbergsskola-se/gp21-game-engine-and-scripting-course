using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float MoveInput { get; private set; }
    public bool JumpInput { get; private set; }

    private void Update()
    {
        MoveInput = Input.GetAxis("Horizontal");
        JumpInput = Input.GetKeyDown(KeyCode.Space);
    }
}