using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("MoveMent")]

    public float moveSpeed = 5.0f;
    private Vector2 currentMoveMent;
    public float jumpPower = 5.0f;
    public LayerMask groundLayerMask;

    [Header("Look")]

    public Transform CameraContainer;
    public float minLook;
    public float maxLook;
    private float camRot;
    public float lookSensitivity;

    private Vector2 mosDelta;

    private bool canLook = true;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // ¸¶¿ì½º Ä¿¼­ ¼û±è
    }
    private void FixedUpdate()
    {
        Move();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            currentMoveMent = context.ReadValue<Vector2>();
        }
        else { currentMoveMent = Vector2.zero; }
    }
    private void Move()
    {
        Vector3 dir = transform.forward * currentMoveMent.y + transform.right * currentMoveMent.x;
        dir *= moveSpeed;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }
}
