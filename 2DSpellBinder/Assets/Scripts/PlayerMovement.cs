using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Rigidbody2D rb;

    public float runSpeed;

    float horizontalMove = 0f;
    bool doJump = false;
    bool doCrouch = false;

    public bool canMove = true;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            print("Jump");
            doJump = true;
        }

        //Is the player moving left and right?
        if(rb.velocity.x > 0.1 || rb.velocity.x < -0.1)
        {
            animator.Play("Walk");
        }

        //if (Input.GetButtonDown("Crouch"))
        //{
        //    doCrouch = true;
        //}
        //else if (Input.GetButtonUp("Crouch"))
        //{
        //    doCrouch = false;
        //}
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            //Move character
            controller.Move(horizontalMove * Time.fixedDeltaTime, doCrouch, doJump);
            doJump = false;
        }
    }
}
