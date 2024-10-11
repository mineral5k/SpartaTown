using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateController : MonoBehaviour
{
    private Animator animator;
    private PlayerController playerController;

    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponentInParent<PlayerController>();
    }

    private void Start()
    {
        playerController.MoveEvent += Move;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move(Vector2 direction)
    {
        animator.SetBool(isWalking, direction.magnitude > 0.5f);
    }
   
}
