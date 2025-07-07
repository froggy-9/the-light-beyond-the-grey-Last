using UnityEngine;

public class Brench : MonoBehaviour
{
    [SerializeField] private GameObject _hidden;
    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_hidden.activeSelf == false)
        {
            gameObject.SetActive(true);
        }
    }
}
