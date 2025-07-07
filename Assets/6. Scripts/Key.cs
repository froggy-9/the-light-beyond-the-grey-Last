using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Key : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1")||collision.gameObject.CompareTag("Player2"))
        {
            ScoreManager._score += 1;
            Destroy(gameObject);
        }
    }
}
