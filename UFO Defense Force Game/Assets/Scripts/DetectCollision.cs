using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // dont destroy the player when an enemy touches them 
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // destroy this object
            Destroy(other.gameObject); // destroy the other object that collides with it
        }
    }
}
