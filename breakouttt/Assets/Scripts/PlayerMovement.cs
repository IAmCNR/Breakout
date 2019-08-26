using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float paddleSpeed = 0.8f;

    private Vector3 playerPos = new Vector3(0, -2f, 0);

    private void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -3.2f, 3.2f), -2f, 0);
        transform.position = playerPos;

    }
}