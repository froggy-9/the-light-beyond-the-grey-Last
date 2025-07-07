using UnityEngine;

public class ColorTogetHidden : MonoBehaviour
{
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;

    private void Update()
    {
        if (Button1 == null && Button2 == null)
        {
            Destroy(gameObject);
        }
    }
}
