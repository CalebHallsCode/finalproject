﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runner : MonoBehaviour
{
    public static float distanceTraveled;
    public Vector3 jumpVelocity;

    public float acceleration;
    public Rigidbody rb;

    private bool touchingPlatform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        distanceTraveled = transform.localPosition.x;


        if (touchingPlatform && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jumpVelocity, ForceMode.VelocityChange);

        }
        distanceTraveled = transform.localPosition.x;


        if (Input.GetMouseButton(0))
        {
            rb.useGravity = false;
            transform.Translate(0f, 0f, 0f);

        }
        else
        {
            rb.useGravity = true;
            transform.Translate(6f * Time.deltaTime, 0f, 0f);

        }

    }
    void FixedUpdate()
    {
        if (touchingPlatform)
        {
            rb.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
        }
    }

    void OnCollisionEnter()
    {
        touchingPlatform = true;
    }

    void OnCollisionExit()
    {
        touchingPlatform = false;
    }


    void PauseGame()
    {
    }
}

