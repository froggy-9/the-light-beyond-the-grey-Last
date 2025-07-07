using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundBar : MonoBehaviour
{
    [SerializeField] private GameObject BackgroundMusic;
    [SerializeField] private AudioSource backmusic;
    public void BackGroundMusicOffButton() //������� Ű�� ���� ��ư
    {
        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //������� �����ص�
        if (backmusic.isPlaying) backmusic.Pause();
        else backmusic.Play();
    }


    //[SerializeField]private GameObject SoundManager;

    //public void SoundOn()
    //{
    //    SoundManager.SetActive(true);
    //}

    //public void SoundOff()
    //{
    //    SoundManager.SetActive(false);
    //}
}
