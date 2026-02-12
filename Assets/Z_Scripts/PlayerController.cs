using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    Vector2 moveInput;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] BoxCollider2D myFeetCollider;
    [SerializeField] CapsuleCollider2D myCapsuleCollider;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Hazard")
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Enemy")))
        {
            SceneManager.LoadScene(0);
        }


    }
}
