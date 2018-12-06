
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Publlic Class playGame MonoBehaviour
public class nextLevel3 : MonoBehaviour
{

    // Triggers collider of computer sprite at the ent to go to next Scene
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level_003");
    }

}

