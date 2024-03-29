using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables for calling rigidbodys animators and audio sources
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    // variables for particles
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    // variables for audio clips
    public AudioClip jumpSound;
    public AudioClip crashSound;
    // variables for player controlling
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // use spacebar for jump and checks to see if the player has jumped
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) 
        {
            //apply a force in the y axis immediately when space is pressed
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }
    //onCollisionEnter method sets is on ground back to true when the player collider touches the ground again preventing double jumps
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //plays our dirt particles when on ground
            dirtParticle.Play();
        }
        // we can use this same collision detection method to detect if we got a game over as well as preventing the double jump
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}