// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Public Class
public class DeathFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // If the player falls below level the call die function
        if (gameObject.transform.position.y <= -4)
        {
            Die();
        }
    }

    // loads user to lose scene
    void Die()
    {
        SceneManager.LoadScene("Lose_Screen");
    }
}
