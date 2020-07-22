using UnityEngine;

public class RotationObject : MonoBehaviour
{
    private Quaternion _rotation;
    private Vector3 _touchPosition;
    private float _speedRotation = 2f;
    private Touch _touch;
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            if (_touch.phase == TouchPhase.Moved)
            {
                _rotation = Quaternion.Euler(_touch.deltaPosition.y * _speedRotation * Time.deltaTime, 0f,
                    -_touch.deltaPosition.x * _speedRotation * Time.deltaTime);
                transform.rotation = _rotation * transform.rotation;
            }
        }
    }
}
