using Deimos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour
{
    // Set player as target
    private GameObject targetShip;

    // On start, find the target player (player tag)
    private void Awake()
    {
        targetShip = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        // on each update, if the player is not null -> rotate toward player
        if (!(targetShip == null))
        {
            // Rotate the camera every frame so it keeps looking at the target
            transform.LookAt(targetShip.transform);

            // Same as above, but setting the worldUp parameter to Vector3.up sets the text to the correct alignment
            transform.LookAt(targetShip.transform, Vector3.up);
        }

    }
}
