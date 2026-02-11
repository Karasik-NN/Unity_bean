using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class characterControll : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // animator=GetComponentChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

    }



    void Update()
    {
        moveInput = 0;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            moveInput = -1;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            moveInput = 1;
        }

        if (moveInput > 0)
        {
            spriteRenderer.flipX = false;

        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipY = false;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position = new Vector2(moveInput * moveSpeed * Time.deltaTime, 0));
    }
}