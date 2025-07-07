using UnityEngine;
using UnityEngine.UIElements;

public class GroundRotate : MonoBehaviour
{
    private float _rotZ;
    [SerializeField]private float _rotationSpeed;
    [SerializeField]private bool _clockWiseRotation;

    private void Update()
    {
        if( _clockWiseRotation ==false)
        {
            _rotZ += Time.deltaTime * _rotationSpeed;
        }
        else
        {
            _rotZ += -Time.deltaTime * _rotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0,0,_rotZ);
    }

}
