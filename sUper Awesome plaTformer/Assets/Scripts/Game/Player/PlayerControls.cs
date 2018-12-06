// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Public Class
public class PlayerControls : MonoBehaviour {


    //Public variables for player speed, jumping, and ground detect
    public int moveSpeed;
    public int jumpPower;
    public bool detectGround;

    //Private variables  for player facing direction, move inputs, double jump feature
    private bool faceDirection;
    private float moveControl;
    private int maxjumps = 2;
    private int jumpsAttempts;


    // Update is called once per frame
    void Update ()
    {
        //Calls for player move function
        PlayerMove();
	}

    void PlayerMove()
    {
        //Controls... 
        //left/right move
        moveControl = Input.GetAxis("Horizontal");

        //call jump function 
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        
        //Animations...
        //Turns on and off the run animation based on direction and whether the player is moving
        if (moveControl == Input.GetAxis ("Horizontal") && moveControl != 0 && detectGround == true)
        {
            GetComponent<Animator>().SetBool("isRunning", true);
        }
        else 
        {
            GetComponent<Animator>().SetBool("isRunning", false);
        }

        //Player Direction...
        //Flips the player into the right direction based on the user inputs from controls
        if (moveControl < 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = true;  
        }
        else if(moveControl > 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //Physics
        // Uses vector2 and rigibody velocity for actual movement
        gameObject.GetComponent<Rigidbody2D>().velocity =
            new Vector2(moveControl * moveSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    // Jump fuunction
    void Jump()
    {
        // jump feature must be grounded and then adds force to the rigibody and resets the ground detection, also has a counter for double jump
        if (jumpsAttempts > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
            detectGround = false;
            jumpsAttempts = jumpsAttempts - 1; 
        }

        //Returns 
        if(jumpsAttempts == 0)
        { 
            return;
        } 
    }

    // Ground/enemy detection and double jump reset
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if ground is detected reset jumpcount
        if (collision.gameObject.tag == "Ground")
        {
            detectGround = true;
            jumpsAttempts = maxjumps;
        }

        // if landing on enemy, reset jumpcount
        if (collision.gameObject.tag == "Enemy")
        {
            detectGround = true;
            jumpsAttempts = maxjumps;
        }
    }


}

