using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class StoryHandler : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        // ���� �ִϸ��̼��� üũ�ϰ��� �ϴ� �ִϸ��̼����� Ȯ��
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("RealStoryAnimation") == true)
        {
            // ���ϴ� �ִϸ��̼��̶�� �÷��� ������ üũ
            float animTime = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
            if (animTime >= 1.0f)
            {
                SceneManager.LoadScene(4);
            }
        }

    }
}
