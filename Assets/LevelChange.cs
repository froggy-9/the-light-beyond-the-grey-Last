//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelChange : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        // ���� �ִϸ��̼��� üũ�ϰ��� �ϴ� �ִϸ��̼����� Ȯ��
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("LevelChangeani") == true)
        {
            // ���ϴ� �ִϸ��̼��̶�� �÷��� ������ üũ
            float animTime = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
            if (animTime >= 1.0f)
            {
                Destroy(gameObject);
            }
        }

    }
}
