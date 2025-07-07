using UnityEngine;

public class CameraTwo : MonoBehaviour

{
    public Transform virtualCameraTransform;
    public float smoothTime = 0.15f;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (virtualCameraTransform != null)
        {
            Vector3 targetPosition = virtualCameraTransform.position;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

            // ȸ���� �ε巴�� �ϰ� �ʹٸ� �Ʒ� �ڵ� �߰�
            Quaternion targetRotation = virtualCameraTransform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }
}
