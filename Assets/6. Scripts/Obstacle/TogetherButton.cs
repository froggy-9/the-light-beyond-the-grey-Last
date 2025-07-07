using UnityEngine;

public class TogetherButton : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1")||collision.gameObject.CompareTag("Player2"))
        {
            gameObject.SetActive(false);
        }
    }
}
