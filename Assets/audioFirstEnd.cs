using UnityEngine;

public class audioFirstEnd : MonoBehaviour
{
    private void Start()
    {
        // AudioManager를 찾아서 삭제
        AudioManager audioManager = FindObjectOfType<AudioManager>();
        if (audioManager != null)
        {
            Destroy(audioManager.gameObject);
        }
    }
}