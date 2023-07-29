using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 2;

    private Vector3 moveVelocity;
    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        Move();
        rb.velocity = moveVelocity;
    }

    private void Move()
    {
        moveVelocity = new Vector3(PlayerInput.movement.x * speed, rb.velocity.y, PlayerInput.movement.y * speed);
    }
}
