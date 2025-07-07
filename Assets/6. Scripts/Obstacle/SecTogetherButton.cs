using UnityEngine;

public class SecTogetherButton : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            Destroy(gameObject);
        }
    }
}
