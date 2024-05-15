using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    
    public Vector3 finishPos = Vector3.zero; // Target position for the platform
    public float speed = 0.5f; // Speed of the platform movement
    private Vector3 startPos; // Starting position of the platform
    private float trackPercent = 0; // Percentage of the way the platform has moved
    private int direction = 1; // Direction of movement (1 for down, -1 for up)

    void Start()
    {
        startPos = transform.position; // Store the starting position
    }

    void Update()
    {
        trackPercent += direction * speed * Time.deltaTime; // Calculate the percentage of the way the platform has moved
        float y = Mathf.Lerp(startPos.y, finishPos.y, trackPercent); // Linearly interpolate between start and end positions
        transform.position = new Vector3(transform.position.x, y, transform.position.z); // Move the platform vertically

        // Reverse direction when reaching the target position
        if ((direction == 1 && trackPercent >= 0.9f) || (direction == -1 && trackPercent <= 0.1f))
        {
            direction *= -1; // Change direction
        }
    }
}

