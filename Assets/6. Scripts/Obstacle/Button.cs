using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box")||collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
