using UnityEngine;

public class Elevator : MonoBehaviour
{
    private float _speed = 2f;
    private bool isHorizontal;
    private bool hitTrigger;
    private bool isMovingUp;

    private Rigidbody2D _rigid;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(!isHorizontal)
        {
            if(isMovingUp&&!hitTrigger)
            {
                _rigid.linearVelocity = Vector2.up * _speed;
            }

            if(!isMovingUp && !hitTrigger)
            {
                _rigid.linearVelocity = Vector2.down * _speed;
            }
        }

        if (isHorizontal)
        {
            if (isMovingUp && !hitTrigger)
            {
                _rigid.linearVelocity = Vector2.right * _speed;
            }

            if (!isMovingUp && !hitTrigger)
            {
                _rigid.linearVelocity = Vector2.left * _speed;
            }
        }
    }

    void Turn()
    {
        isMovingUp = !isMovingUp;
        hitTrigger = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ElevatorTrigger"))
        {
            hitTrigger = true;
            _rigid.linearVelocity = Vector2.zero;
            Invoke("Turn", 5);
        }
    }
}
