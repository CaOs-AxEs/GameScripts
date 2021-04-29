using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera cam;
    private const float JUMP_AMOUNT = 9f;
    private Rigidbody2D playerRigidBody2D;
    public float startFOV = 60f;
    public float maxFOV = 90f;
    Transform myT;
    public float t = 0.5f;
    public float speed;
    public float jump;
    private float moveInput;


    private void Awake()
    {
        playerRigidBody2D = GetComponent<Rigidbody2D>();
        myT = transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        moveInput = Input.GetAxis("Horizontal");
        playerRigidBody2D.velocity = new Vector2(moveInput * speed, playerRigidBody2D.velocity.y);
    }

    private void Jump()
    {
        playerRigidBody2D.velocity = Vector2.up * JUMP_AMOUNT;
    }
}
