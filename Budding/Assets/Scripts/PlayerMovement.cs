using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    //Variables declared
    public float speed = 5;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    //Adding ability to animate the movement of the player
    Animator animator;

    //These are used for the player to stop moving when they have died in game so that the player 
    // no longer controls the character
    private void OnEnable()
    {
        characterController.enabled = true;
        PlayerHealth.OnPlayerDeath += DisablePlayerMovement;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= DisablePlayerMovement;
    }
    // ------------------------------------------------------------------- //
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
       
    }
    // ------------------------------------------------------------------- //

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();

    }

    void Update()
    {
        var x_axis = Input.GetAxis("Horizontal");
        var y_axis = Input.GetAxis("Vertical");

        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * y_axis;
            turnVelocity = transform.up * rotationSpeed * x_axis;

        }


        if (Input.GetButtonDown("Jump"))
        {
            moveVelocity.y = jumpSpeed;
        }

        //Adding gravity // ------------------------------------------------------------------- //
        moveVelocity.y += gravity * Time.deltaTime; 
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);

        animator.SetFloat("speed", Mathf.Abs( y_axis)) ;
 
    }

    // Used in conjunction with the Game Over screen and the above OnEnable/OnDisable //
    private void DisablePlayerMovement()
    {
        speed = 0;
    }

    private void EnablePlayerMovement()
    {
        speed = 5;
    }
}
