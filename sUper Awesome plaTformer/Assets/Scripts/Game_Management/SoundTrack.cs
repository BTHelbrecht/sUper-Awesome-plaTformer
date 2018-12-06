// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Public Class
public class SoundTrack : MonoBehaviour {

    //public variables to get sound clip and use audio source component
    public AudioClip music;
    public AudioSource source;

    //Private Variable for button turn on off ability
    private bool on = true;


	// Use this for initialization
	void Start () {
        // Loads the audio clip into the audio source
        source.clip = music;
	}
	

	// Update is called once per frame
	public void Update () {
        // plays sound clip
        if (on == true)
        {
            source.Play();
        }
	}
    

    //Function for on off
    public void Playing()
    {
        // if on is a valuse make it the opposite value... on or off
        on = !on;
    }
}
