using UnityEngine;
using UnityEngine.InputSystem;

public class Player2_Move : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private Vector2 _moveDir;
    private float _moveX;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpPower = 5f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private GameObject _groundChecker;
    [SerializeField] private Vector2 size;
    private bool _isGround = false;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CheckGround();
        MoveX();
    }

    public void OnPlayer2(InputValue value)
    {
        _moveX = value.Get<Vector2>().x;
    }

    private void MoveX()
    {
        _rigid.linearVelocityX = _moveX * _speed;
    }

    private void CheckGround()
    {
        Collider2D hit = Physics2D.OverlapBox(_groundChecker.transform.position, size, 1f, groundMask);
        _isGround = hit != null;
    }

    public void OnJump2(InputValue value)
    {
        if (!_isGround)
            return;
        _rigid.linearVelocityY = 0;
        _rigid.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(_groundChecker.transform.position, size);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGround = true;
    }
}