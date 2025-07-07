using UnityEngine;

public class BoxLocation : MonoBehaviour
{
    [SerializeField] private Transform _boxTarget;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BoxTrigger"))
        {
            transform.position = _boxTarget.position;
        }
    }
}
