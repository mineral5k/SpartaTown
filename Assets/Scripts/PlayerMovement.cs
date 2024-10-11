using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController controller;
    private Rigidbody2D playerRigidbody;
    private Vector2 moveDirection = Vector2.zero;


    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.MoveEvent += Move;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyMove(moveDirection);
    }

    private void Move(Vector2 inputDirection)
    {
        moveDirection = inputDirection;
    }

    private void ApplyMove(Vector2 direction)
    {
        direction *= 5;
        playerRigidbody.velocity = direction;
    }

    
}
