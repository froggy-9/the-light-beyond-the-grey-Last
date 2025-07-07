using UnityEngine;

public class Hidden : MonoBehaviour
{
    [SerializeField] private GameObject Button;
    private void Update()
    {
        if(Button==null)
        {
            Destroy(gameObject);
        }
    }
}
