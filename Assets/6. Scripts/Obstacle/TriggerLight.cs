using UnityEngine;

public class TriggerLight : MonoBehaviour
{
    [SerializeField] private GameObject _reflexLight;

    private void Awake()
    {
        _reflexLight.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        while (collision.gameObject.CompareTag("PrismLight"))
        {
            _reflexLight.SetActive(true);
        }
    }
}
