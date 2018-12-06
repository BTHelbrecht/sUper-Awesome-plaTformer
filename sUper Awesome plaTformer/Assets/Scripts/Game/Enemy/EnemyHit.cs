// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Public Class
public class EnemyHit : MonoBehaviour {

    // Private variable for player gameobject
    private GameObject player;

    //Function for collision with enemy load the lose scene
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = GameObject.Find("Player");

        // loads scene
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Lose_Screen");
        }
    }
}
