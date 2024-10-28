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

    public Transform cameraContainer;
    public float minLook;
    public float maxLook;
    private float camRot;
    public float lookSensitivity;

    private Vector2 mosDelta;


    private Rigidbody rb;
    public StaminaUi staminaUi;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // ¸¶¿ì½º Ä¿¼­ ¼û±è
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void LateUpdate()
    {
        CameraLook();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            currentMoveMent = context.ReadValue<Vector2>();
        }
        else { currentMoveMent = Vector2.zero; }
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpPower,ForceMode.Impulse );

            staminaUi.SetDecreaseStamina();


        }
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        mosDelta = context.ReadValue<Vector2>();
    }


    private void Move()
    {
        Vector3 dir = transform.forward * currentMoveMent.y + transform.right * currentMoveMent.x;
        dir *= moveSpeed;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }

    void CameraLook()
    {
        camRot += mosDelta.y * lookSensitivity;
        camRot = Mathf.Clamp(camRot, minLook, maxLook);
        cameraContainer.localEulerAngles = new Vector3(-camRot, 0, 0);

        transform.eulerAngles += new Vector3(0, mosDelta.x * lookSensitivity, 0);
    }


    bool IsGrounded()
    {
        Ray[] rays = new Ray[4]
        {
            new Ray(transform.position + (transform.forward * 0.2f) + (transform.up * 0.01f), Vector3.down),
            new Ray(transform.position + (-transform.forward * 0.2f) + (transform.up * 0.01f), Vector3.down),
            new Ray(transform.position + (transform.right * 0.2f) + (transform.up * 0.01f), Vector3.down),
            new Ray(transform.position + (-transform.right * 0.2f) +(transform.up * 0.01f), Vector3.down)
        };

        for (int i = 0; i < rays.Length; i++)
        {
            if (Physics.Raycast(rays[i], 0.1f, groundLayerMask))
            {
                return true;
            }
        }

        return false;
    }
}
