using UnityEngine;
using UnityEngine.InputSystem; // This line is new!

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 moveInput;

    // This function is called automatically if you have a PlayerInput component
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        // If you don't want to set up a PlayerInput component yet, 
        // use this simple direct read:
        Vector2 currentMove = Vector2.zero;

        if (Keyboard.current.wKey.isPressed) currentMove.y = 1;
        if (Keyboard.current.sKey.isPressed) currentMove.y = -1;
        if (Keyboard.current.aKey.isPressed) currentMove.x = -1;
        if (Keyboard.current.dKey.isPressed) currentMove.x = 1;

        transform.Translate(currentMove.normalized * moveSpeed * Time.deltaTime);
    }
}