using UnityEngine;
using UnityEngine.InputSystem;

public class JumpOne : MonoBehaviour
{
    [SerializeField]private float _jump = 500;
    private Rigidbody2D _rigid;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Keyboard.current.wKey.wasPressedThisFrame)
        {
            _rigid.AddForce(new Vector2(_rigid.linearVelocity.x, _jump));
        }
    }
}
