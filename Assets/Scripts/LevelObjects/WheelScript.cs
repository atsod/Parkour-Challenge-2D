using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private int rotationDirection;

    void FixedUpdate()
    {
        gameObject.transform.Rotate(Vector3.forward, rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
