using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdCage : MonoBehaviour
{
    [SerializeField] private GameObject Key;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("BirdCage Collision");
        if (Key==null)
        {
            if(collision.gameObject.CompareTag("Player1")||collision.gameObject.CompareTag("Player2"))
            {
                SceneManager.LoadScene(3);
                UnlockNewLevel();
                ScoreManager._score = 0;
                Debug.Log("BirdCage Works");
            }
        }
    }

    private void UnlockNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }
}