using UnityEngine;

public class TouchReset : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            this.transform.position = target.position;
        }
    }
}
