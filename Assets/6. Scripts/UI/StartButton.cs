using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class StartButton : MonoBehaviour
{
    public void Loading()
    {
        SceneManager.LoadScene(1);
    }

    public void StageChoose()
    {
        SceneManager.LoadScene(3);
    }

    public void TutorialInfor()
    {
        SceneManager.LoadScene(5);
    }

    public void TutorialStory()
    {
        SceneManager.LoadScene(4);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(6);
    }

    public void FirstStage()
    {
        SceneManager.LoadScene(7);
    }

    public void SecondStage()
    {
        SceneManager.LoadScene(8);
    }

    public void ThirdStage()
    {
        SceneManager.LoadScene(9);
    }

    public void ForthStage()
    {
        SceneManager.LoadScene(10);
    }    

    public void FifthStage()
    {
        SceneManager.LoadScene(11);
    }

    public void SixthStage()
    {
        SceneManager.LoadScene(12);
    }

    public void SixtStageStory()
    {
        SceneManager.LoadScene(13);
    }

    public void Ending()
    {
        SceneManager.LoadScene(14);
    }

    public void Exit()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll(); // 모든 저장 데이터 삭제
        PlayerPrefs.Save();      // 즉시 저장
        Debug.Log("탈출");
    }

    public void DeleteKeyNum()
    {
        ScoreManager._score = 0;
    }
}
