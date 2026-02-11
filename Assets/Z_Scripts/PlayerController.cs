using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 moveInput;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] BoxCollider2D myFeetCollider;

    [SerializeField] bool isJumpReq;

    private void FixedUpdate()
    {
        Running();
        Jumping();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        if(value.isPressed)
        {
            isJumpReq = true;
        }
    }

    private void Running()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * 5f, rb.linearVelocity.y);
        rb.linearVelocity = playerVelocity;
    }

    private void Jumping()
    {
        if (!isJumpReq) return;
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 28f);
        isJumpReq = false;
    }
}
