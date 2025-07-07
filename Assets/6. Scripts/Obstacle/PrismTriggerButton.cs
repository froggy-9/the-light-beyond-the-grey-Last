using UnityEngine;

public class PrismTriggerButton : MonoBehaviour
{
    [SerializeField] private GameObject _hiddenDoor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PrismLight"))
        {
            _hiddenDoor.SetActive(false);
        }
        else
        {
            _hiddenDoor.SetActive(true);
        }
    }
}
