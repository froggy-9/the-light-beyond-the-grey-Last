using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Prism : MonoBehaviour
{
    [Header("회전속도 조정")]
    [SerializeField][Range(1f, 100f)] float _rotateSpeed = 50f;

    //private const float LengthMultipiler = 4f;

    //[SerializeField]private Vector3 _sourceVector;
    //[SerializeField]private float _rotationRange;
    //[SerializeField] private Vector3 _rotatedVector;

    //private Vector2 _limitA;
    //private Vector2 _limitB;

    private void Update()
    {
        if(Keyboard.current.zKey.isPressed)
        {
            transform.Rotate(0,0,Time.deltaTime *  _rotateSpeed, Space.Self);
        }
        if(Keyboard.current.xKey.isPressed)
        {
            transform.Rotate(0,0,-Time.deltaTime*_rotateSpeed, Space.Self);
        }
    }

    //private void OnValidate()
    //{
    //    _limitA = Quaternion.AngleAxis(-_rotationRange/2, Vector3.forward) * _sourceVector;
    //    _limitB = Quaternion.AngleAxis(_rotationRange/2, Vector3.forward) * _sourceVector;
    //}

    //private void OnDrawZismos()
    //{
    //    var p = transform.position;
    //    Gizmos.color = Color.white;
    //    Gizmos.DrawRay(from: p, direction: _sourceVector * LengthMultipiler);
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawRay(from: p, direction: _rotatedVector * LengthMultipiler);
    //    Gizmos.color = Color.green;
    //    Gizmos.DrawRay(from: p, direction: _limitA * LengthMultipiler);
    //    Gizmos.DrawRay(from: p, direction: _limitB * LengthMultipiler);
    //}

    //private void Rotate()
    //{
    //    var randomRotationAngle = Random.Range(-_rotationRange / 2, _rotationRange / 2);
    //    _rotatedVector = Quaternion.AngleAxis(randomRotationAngle, Vector3.forward) * _sourceVector;
    //}
}
