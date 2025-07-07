using UnityEngine;

public class TwoPeopleButton : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            Destroy(gameObject);
        }
    }
}
