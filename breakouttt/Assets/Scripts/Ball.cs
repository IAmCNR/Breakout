using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballInitialVelocity;
    private float randomBall;
    private Rigidbody rb;
    private bool ballInPlay;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        randomBall = Random.Range(-150f, 150f);
    }

    
    void Update()
    {
        if(Input.GetKeyDown("space") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(randomBall, ballInitialVelocity, 0));

        }
    }
}
