using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource playerAudio;

    public float horizontalInput;
    public float speed;

    public float xRange;
    public int pickups;

    public AudioClip blasterSound;
    public AudioClip explosionSound;
    public AudioClip pickupSound;
    public AudioClip gameOverSound;
    

    public Transform blaster;

    public GameObject laserBolt;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // initialize inputs to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // moves player left and right 
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // keep player within boundary
        // right side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // left side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if space bar is pressed fire a laser and the game is still moving
        if (Input.GetKeyDown(KeyCode.Space) && Time.timeScale > 0)
        {
            // create a laser bolt at the blasters position and keep its rotation
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
            playerAudio.PlayOneShot(blasterSound, 1.0f);
        }


    }
    // delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        // if the other game object is tagged "Pickup" then it gets destroyed and 1 is added to pickups variable and logged in the console.
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            pickups++;
            Debug.Log("You have " + pickups + " Powerups!");
            playerAudio.PlayOneShot(pickupSound, 1.0f);
        }
    }
    public void Explosion()
    {
        playerAudio.PlayOneShot(explosionSound, 1.0f);// sound for explosions when enemies are destroyed
    }
    public void GameOverSound()
    {
        playerAudio.PlayOneShot(gameOverSound, 1.0f);// sound for when you lose the game
    }
}
