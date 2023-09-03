using UnityEngine;

public class WheelMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private int _rotationDirection;

    void FixedUpdate()
    {
        gameObject.transform.Rotate(Vector3.forward, _rotationDirection * _rotationSpeed * Time.deltaTime);
    }
}
