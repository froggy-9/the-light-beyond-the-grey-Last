using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;
    public float incrementAmount = 0.1f;
    public float incrementInterval = 0.1f;
    private float timer = 0f;

    void Start()
    {
        // 슬라이더 초기화 (예시)
        slider.minValue = 0f;
        slider.maxValue = 100f;
        slider.value = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= incrementInterval)
        {
            timer = 0f;
            if (slider.value < slider.maxValue)
            {
                slider.value += incrementAmount;
            }
            else if(slider.value == slider.maxValue)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}