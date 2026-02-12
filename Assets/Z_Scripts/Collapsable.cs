using UnityEngine;

public class Collapsable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("DestroyCollapsable", 2f);
        }
    }

    void DestroyCollapsable()
    {
        Destroy(gameObject);
    }
}
