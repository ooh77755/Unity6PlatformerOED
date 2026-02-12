using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(20f, 0f);
        Invoke("DestroyBullet", 0.5f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
