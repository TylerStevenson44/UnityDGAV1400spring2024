using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
    public ScoreManager scoreManager; // reference to the score manager
    public PlayerController playerController;// refer to playercontroller script

    public int scoreToGive; // how much we increase the score

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // find our score manager script and gameobject
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

    }
    void OnTriggerEnter(Collider other)
    {
        // dont destroy the player when an enemy touches them 
        if (!other.gameObject.CompareTag("Player"))
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject); // destroy this object
            Destroy(other.gameObject); // destroy the other object that collides with it
            playerController.Explosion();
            
        }
    }
}
