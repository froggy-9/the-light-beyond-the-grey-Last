using UnityEngine;

public class OnlyOnePlaterTouch : MonoBehaviour
{
    [SerializeField] private GameObject Button;

    private void Update()
    {
        if(Button == null)
        {
            Destroy(gameObject);
        }
    }
}
