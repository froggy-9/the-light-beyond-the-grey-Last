using UnityEngine;
using UnityEngine.InputSystem;

public class JumpController : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 5;
    [SerializeField]private Transform groundCheck;
    [SerializeField]private LayerMask groundLayer;
    bool _isGrounded;
    private Rigidbody2D _rigid;
    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(1.8f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Keyboard.current.wKey.wasPressedThisFrame && _isGrounded)
        {
            _rigid.AddForce(new Vector2(_rigid.linearVelocity.x, _jumpPower));
        }
    }
}
