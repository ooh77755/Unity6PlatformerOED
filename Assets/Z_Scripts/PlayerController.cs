using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 moveInput;

    [SerializeField] Rigidbody2D rb;

    private void FixedUpdate()
    {
        Running();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void Running()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * 5f, rb.linearVelocity.y);
        rb.linearVelocity = playerVelocity;
    }
}
