using UnityEngine;

public class LeftRightRotate : MonoBehaviour
{
    private Rigidbody2D _rigid;
    [SerializeField] private float _speed;
    [SerializeField] private float _restartTimer;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        InvokeRepeating("MoveRight",0,_restartTimer);
        InvokeRepeating("MoveLeft",_restartTimer/2,_restartTimer);

    }

    private void MoveRight()
    {
        _rigid.linearVelocity = transform.right * _speed;
    }    

    private void MoveLeft()
    {
        _rigid.linearVelocity = -transform.right * _speed;
    }
}
