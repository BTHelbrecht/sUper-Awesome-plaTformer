// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//Public Class
public class Finish : MonoBehaviour
{

    // public variables for time elapsed, total points, and the gameobjec that corrispond with them
    public float timeElapsed;
    public int points;
    public GameObject timer;
    public GameObject score;


    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        timer.gameObject.GetComponent<Text>().text = ("Elapsed Time: " + Mathf.Round(timeElapsed));
        score.gameObject.GetComponent<Text>().text = ("Score: " + points);
    }

    // When player enters collider on last level triggers it here and call countscore function
    void OnTriggerEnter2D(Collider2D collision)
    {
        CountScore();
    }

    //This tallies up the point and give win conditions/lose conditions not based on enemy fatality
    void CountScore()
    {
        points = (300 * 10) - (int)(timeElapsed * 10);

        //conditions
        if (timeElapsed == 300)
        {
            SceneManager.LoadScene("Lose_Screen");
        }
        else if (points <= 1499)
        {
            SceneManager.LoadScene("Lose_Screen");
        }
        else
        {
            SceneManager.LoadScene("Win_Screen");
        }
    }
}