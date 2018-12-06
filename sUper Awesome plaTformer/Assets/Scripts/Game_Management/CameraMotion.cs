// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Public Class
public class CameraMotion : MonoBehaviour
{

    // Public variables for the camera edges
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Private variable for the player gameobject
    private GameObject player;

    // Use this for initialization
    void Start()
    {
        // find the player gameobject via tag system
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // follows the player with the camera untill clap limits reachs then the camera will stop moving with the player
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
