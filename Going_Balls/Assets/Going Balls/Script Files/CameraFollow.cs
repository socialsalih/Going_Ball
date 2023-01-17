using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object to follow
    public float smoothSpeed = 0.125f; // The speed at which the camera will follow the target
    public Vector3 offset; // The distance between the camera and the target

    private void FixedUpdate()
    {
        // Get the position of the target
        Vector3 desiredPosition = target.position + offset;
        // Smoothly move the camera towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Update the camera's position
        transform.position = smoothedPosition;
        // Make the camera look at the target
        transform.LookAt(target);
    }
}

