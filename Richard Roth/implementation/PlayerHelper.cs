using Deimos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{
    // Set variables
    [SerializeField] private Transform[] spawnsPoints;
    [SerializeField] public float randomRadius;
    [SerializeField] public bool sameHeight;
    [SerializeField] private GameObject spawnEntry;
    [SerializeField] private GameObject player;

    // Helper spawner
    public void Spawn()
    {
        // Check if spawn points array has been populated
        if (spawnsPoints.Length > 0)
        {
            // assign a random spawn
            int spawnIndex = Random.Range(0, spawnsPoints.Length);

            // set spawn position
            Vector3 spawnCenter = spawnsPoints[spawnIndex].position;
            Vector3 spawnLoc = spawnCenter + (Random.insideUnitSphere * randomRadius);

            // Ensure ship spawns at the same height of the player
            if (sameHeight == true)
            {
                spawnLoc = new Vector3(spawnLoc.x, 0f, spawnLoc.z);
            }

            // Spawn the assistance ship
            Instantiate(spawnEntry, spawnLoc, Quaternion.identity, player.transform);
                
        }


    }


}

    

