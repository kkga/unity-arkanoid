using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialVelocity = 600f;
    private Rigidbody rb;
    private bool ballInPlay;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.AddForce(new Vector3(initialVelocity, 0, initialVelocity));
        }
    }
}
