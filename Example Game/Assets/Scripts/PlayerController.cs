using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public CharacterController characterController;

    private Vector3 moveInput;

    public Transform camTransform;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal")*MoveSpeed*Time.deltaTime;
        moveInput.z = Input.GetAxis("Vertical")*MoveSpeed * Time.deltaTime;

        characterController.Move(moveInput);

        // control rotacion camara




    }
}
