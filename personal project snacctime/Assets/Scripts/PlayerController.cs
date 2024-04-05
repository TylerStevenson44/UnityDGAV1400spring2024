using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float horizontalInput;
    public float speed = 30.0f;
    public float xRange = 10.0f;
    public float yRange = 10.0f;
    public float jumpForce = 10.0f;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // input to move our player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // use spacebar for jump and checks to see if the player has jumped
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //apply a force in the y axis immediately when space is pressed
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
            Debug.Log("too far left");

        }
        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
            Debug.Log("too far right");
        }
        if (transform.position.y < -yRange)
        {
            Destroy(gameObject);
            Debug.Log("too far down");
        }
        if (transform.position.y > yRange)
        {
            Destroy(gameObject);
            Debug.Log("too far up");
        }
    }
}
