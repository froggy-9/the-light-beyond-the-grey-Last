using UnityEngine;

public class audioFirstEnd : MonoBehaviour
{
    private void Start()
    {
        // AudioManager�� ã�Ƽ� ����
        AudioManager audioManager = FindObjectOfType<AudioManager>();
        if (audioManager != null)
        {
            Destroy(audioManager.gameObject);
        }
    }
}