using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public event Action<Vector2> MoveEvent;
    public event Action<Vector3> LookEvent;
    private Camera mainCamera;
    [SerializeField] SpriteRenderer playerRenderer;
        
    // Start is called before the first frame update
    private void Awake()
    {
       mainCamera = Camera.main;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = mainCamera.transform.position;
        newPosition.x = transform.position.x;
        newPosition.y = transform.position.y;
        mainCamera.transform.position = newPosition;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 aim = value.Get<Vector2>();
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(aim); 
        aim = (worldPos - (Vector2)transform.position);
        playerRenderer.flipX = (aim.x < 0);
    }

    public void CallMoveEvent(Vector2 direction)
    {
        MoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        LookEvent?.Invoke(direction);
    }

}
