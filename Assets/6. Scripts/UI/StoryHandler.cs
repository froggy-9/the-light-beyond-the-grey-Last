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
        
        // 현재 애니메이션이 체크하고자 하는 애니메이션인지 확인
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("RealStoryAnimation") == true)
        {
            // 원하는 애니메이션이라면 플레이 중인지 체크
            float animTime = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
            if (animTime >= 1.0f)
            {
                SceneManager.LoadScene(4);
            }
        }

    }
}
