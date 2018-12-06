// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Public Class
public class EnemyMove : MonoBehaviour
{
    // Public Variables for enemy move speed and direction
    public float enemySpeed;
    public float xMoveDirection;


    // Update is called once per frame
    void Update()
    {
        //  Uses a ray cast method to touch an collider and change directions
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection, 0) * enemySpeed;
        if (hit.distance < 0.7f)
        {
            // flips the enemy if raycat collides with something
            Flip();
        }
    }


    // Flip function
    void Flip()
    {
        // Flips by assigns -1/1 to make value neg. or pos to flip sprite
        if(xMoveDirection > 0)
        {
            xMoveDirection = -1;
        }
        else
        {
            xMoveDirection = 1;
        }
    }
}
