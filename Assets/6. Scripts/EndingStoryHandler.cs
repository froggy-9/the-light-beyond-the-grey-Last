using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingStoryHandler : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        // ���� �ִϸ��̼��� üũ�ϰ��� �ϴ� �ִϸ��̼����� Ȯ��
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("EndingAnimation") == true)
        {
            // ���ϴ� �ִϸ��̼��̶�� �÷��� ������ üũ
            float animTime = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
            if (animTime >= 1.0f)
            {
                Application.Quit();
            }
        }

    }
}
