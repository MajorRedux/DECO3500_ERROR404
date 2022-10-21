using Deimos;
using SciFiShipController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssistanceTarget : MonoBehaviour
{
    // Assign player manager variable
    [SerializeField] private PlayerManager playerManager;

    private void Awake()
    {
        // Get player manager
        playerManager = FindObjectOfType<PlayerManager>();
    }

    // Trigger on object that triggers on collision
    void OnTriggerEnter(Collider other)
    {
        // If the player (player tag) makes contact
        if (other.CompareTag("Player"))
        {
            // Set assistance target to true
            playerManager.AssistanceTarget = true;
        }
    }
}
