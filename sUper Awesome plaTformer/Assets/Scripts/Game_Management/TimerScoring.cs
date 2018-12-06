// JERARD CARNEY
// 12.2.18

// Librariesusing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Public Class
public class TimerScoring : MonoBehaviour {


    // Public variable, for timer and points earned at end of levels, and for the gamebjects they represent
    public float timeElapsed;
    public int points;
    public GameObject timer;
    public GameObject score;


	// Update is called once per frame
	void Update ()
    {
        //Counter in real time the counts up from 0 and is rounded to an int, then displayed out to the canvas, for both score and time
        timeElapsed += Time.deltaTime;
        timer.gameObject.GetComponent<Text>().text = ("Elapsed Time: " + Mathf.Round(timeElapsed));
        score.gameObject.GetComponent<Text>().text = ("Score: " + points);
    }

    // will call couter function on cillision with computer sprite
    void OnTriggerEnter2D(Collider2D collision)
    {
        CountScore();
    }

    // Calcutaltes point based on time in level each time
    void CountScore()
    {
        points = (300 * 10) - (int)(timeElapsed * 10);
    }

}
