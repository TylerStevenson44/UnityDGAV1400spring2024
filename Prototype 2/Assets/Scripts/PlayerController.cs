using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables for our function and if statements.
    public float horizontalInput;
    public float speed = 30.0f;
    public float xRange = 20.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // we gotta keep the player within the play space 
        if (transform.position.x < -xRange)
        {
            //keeps player from going too far left 
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            // keeps player from going too far right
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // input to move our player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch cookie from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
