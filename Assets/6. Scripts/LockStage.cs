using UnityEngine;
using UnityEngine.InputSystem;

public class LockStage : MonoBehaviour
{
    public UnityEngine.UI.Button[] _buttons;


    private void Awake()
    {
        int unlockedLevel1 = PlayerPrefs.GetInt("UnlockedLevel", 1);

        for (int i = 0; i < _buttons.Length; i++)
            _buttons[i].interactable = false;

        for (int i = 0; i < unlockedLevel1 && i < _buttons.Length; ++i)
            _buttons[i].interactable = true;
        if(unlockedLevel1 ==4)
        {
            _buttons[6].interactable = true;
            _buttons[5].interactable = true;
        }
    }
    private void Update()
    {

        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            _buttons[1].interactable = false;
            _buttons[2].interactable = false;
            _buttons[3].interactable = false;
            _buttons[4].interactable = false;
            _buttons[5].interactable = false;
            _buttons[6].interactable = false;
        }

        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            _buttons[0].interactable = true;
            _buttons[1].interactable = true;
            _buttons[2].interactable = true;
            _buttons[3].interactable = true;
            _buttons[4].interactable = true;
            _buttons[5].interactable = true;
            _buttons[6].interactable = true;
        }

    }

}
