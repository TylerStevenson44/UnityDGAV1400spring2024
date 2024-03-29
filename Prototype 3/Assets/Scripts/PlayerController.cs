using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
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
        }
    }
    //onCollisionEnter method sets is on ground back to true when the player collider touches the ground again preventing double jumps
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        // we can use this same collision detection method to detect if we got a game over as well as preventing the double jump
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}