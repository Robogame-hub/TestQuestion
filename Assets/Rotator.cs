using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public enum RotationAxis { X, Y, Z }
    
    [SerializeField] private RotationAxis rotationAxis = RotationAxis.Y;
    [SerializeField] private float rotationSpeed = 30f; // Скорость вращения (градусов в секунду)

    void Update()
    {
        float deltaTime = Time.deltaTime;
        
        switch (rotationAxis)
        {
            case RotationAxis.X:
                transform.Rotate(Vector3.right * rotationSpeed * deltaTime, Space.World);
                break;
            case RotationAxis.Y:
                transform.Rotate(Vector3.up * rotationSpeed * deltaTime, Space.World);
                break;
            case RotationAxis.Z:
                transform.Rotate(Vector3.forward * rotationSpeed * deltaTime, Space.World);
                break;
        }
    }
}