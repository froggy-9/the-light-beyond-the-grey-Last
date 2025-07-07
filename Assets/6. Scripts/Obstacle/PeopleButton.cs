using UnityEngine;

public class PeopleButton : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            Destroy(gameObject);
        }
    }
}
