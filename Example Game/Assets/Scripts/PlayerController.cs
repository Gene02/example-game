using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public CharacterController characterController;

    private Vector3 moveInput;

    public Transform camTransform;

    public float gravity;

    public float mouseSensitivity;

    public float jumpSpeed;

    private bool canJump;

    public Transform groundCheckpoint;

    public LayerMask Ground;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //moveInput.x = Input.GetAxis("Horizontal")*MoveSpeed*Time.deltaTime;
        //moveInput.z = Input.GetAxis("Vertical")*MoveSpeed * Time.deltaTime;

        Vector3 verticalMove = transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontalMove = transform.right * Input.GetAxis("Horizontal");

        moveInput = horizontalMove + verticalMove;
        
        moveInput = moveInput * MoveSpeed;

        //Gravedad
        moveInput.y += Physics.gravity.y * gravity; 

        characterController.Move(moveInput * Time.deltaTime);

        characterController.Move(moveInput);

        canJump = Physics.OverlapSphere(groundCheckpoint.position, .25f, Ground).Length > 0;

        //salto del jugador
        if (Input.GetButtonDown("Jump") && canJump)
        {
            moveInput.y = jumpSpeed;
        }


        // control rotacion camara

        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;

        

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);

        camTransform.rotation = Quaternion.Euler(camTransform.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));




    }
}
