using UnityEngine;

public class PatrollerEnemyController : MonoBehaviour
{
    float xSpeed = 1f;
    
    [SerializeField] Rigidbody2D rb;

    private void FixedUpdate()
    {
        if(transform.localScale.x > 0)
        {
            Vector2 enemyVelocity = new Vector2(xSpeed, rb.linearVelocity.y);
            rb.linearVelocity = enemyVelocity;
        }
        else
        {
            rb.linearVelocity = new Vector2(-xSpeed, rb.linearVelocity.y);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        transform.localScale = new Vector2(-(Mathf.Sign(rb.linearVelocity.x)), 1f);
    }
}
