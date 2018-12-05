using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public int moveSpeed;
    public int jumpPower;

    private bool faceDirection;
    private float moveControl;

	
	// Update is called once per frame
	void Update ()
    {
        PlayerMove();
	}

    void PlayerMove()
    {
        //Controls
        moveControl = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //Animations
        //Player Direction
        if(moveControl < 0.0f && faceDirection == false)
        {
            FlipPlayer();
        }
        else if(moveControl > 0.0f && faceDirection == true)
        {
            FlipPlayer();
        }
        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity =
            new Vector2(moveControl * moveSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
    }

    void FlipPlayer()
    {
        faceDirection = !faceDirection;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}

