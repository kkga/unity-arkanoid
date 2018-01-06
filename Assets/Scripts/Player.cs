using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movespeed = 20.0f;
    // public float tilt = 0.50f;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);

        rb.velocity = movement * movespeed;

        // tilt player on move
        // rb.rotation = Quaternion.Euler(0f, rb.velocity.x * tilt, 0f);
    }
}
