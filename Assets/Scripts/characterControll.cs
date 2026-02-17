using UnityEngine;
using UnityEngine.InputSystem; // Добавь это!

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float xLimit = 8.5f;

    void Update()
    {
        float moveInput = 0;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            moveInput = -1;
        }
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            moveInput = 1;
        }

        Vector3 newPosition = transform.position + Vector3.right * moveInput * speed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -xLimit, xLimit);
        transform.position = newPosition;
    }
}