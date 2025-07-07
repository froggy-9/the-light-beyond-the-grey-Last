using UnityEngine;
using UnityEngine.InputSystem;

public class PrismLight : MonoBehaviour
{
    [SerializeField] private GameObject _prismMiddle;
    [SerializeField] private GameObject _lightWith;
    [SerializeField] private GameObject _prismLight;

    [SerializeField][Range(1f, 100f)] float _rotateSpeed = 50f;

    private void Awake()
    {
        _prismLight.transform.position = _lightWith.transform.position;
    }
    private void Update()
    {
        _prismLight.transform.position = _prismMiddle.transform.position;

        if (Keyboard.current.zKey.isPressed || Keyboard.current.nKey.isPressed)
        {
            transform.Rotate(0, 0, Time.deltaTime * _rotateSpeed, Space.Self);
        }
        if (Keyboard.current.xKey.isPressed || Keyboard.current.mKey.isPressed)
        {
            transform.Rotate(0, 0, -Time.deltaTime * _rotateSpeed, Space.Self);
        }
    }
}
