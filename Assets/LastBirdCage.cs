using UnityEngine;
using UnityEngine.SceneManagement;

public class LastBirdCage : MonoBehaviour
{
    [SerializeField] private GameObject EndingCanvas;
    [SerializeField] private GameObject Key;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("BirdCage Collision");
        if (Key == null)
        {
            if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
            {
                EndingCanvas.SetActive(true);
                EndingCanvas.transform.Find("Back").gameObject.SetActive(true);
                EndingCanvas.transform.Find("Ending").gameObject.SetActive(true);
                EndingCanvas.transform.Find("Main").gameObject.SetActive(true);

                Debug.Log("EndingCanvas activeSelf: " + EndingCanvas.activeSelf);

                ScoreManager._score = 0;
                Debug.Log("BirdCage Works");
            }
        }
    }
}
