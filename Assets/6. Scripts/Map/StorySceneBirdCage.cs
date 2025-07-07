using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySceneBirdCage : MonoBehaviour
{
    [SerializeField] private GameObject Key;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("BirdCage Collision");
        if (Key == null)
        {
            if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
            {
                SceneManager.LoadScene(15);
                ScoreManager._score = 0;
                Debug.Log("BirdCage Works");
            }
        }
    }
}
