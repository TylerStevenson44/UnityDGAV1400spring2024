using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //serialize field for access to edit private varables within inspector
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    public Rigidbody playerRb;
    private Vector3 moveDirection;
    private bool isJumping;



    //set our input floats for movement
    [SerializeField] private float verticalInput;
    [SerializeField] private float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        //we get our character controller component 
        controller = GetComponent<CharacterController>();
        // use a rigidbody for gravity 
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {


        //assign our floats buttons 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move our character around with our inputs
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);

        //make our character jump with space
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent("Plane"))
        {
            isJumping = false;
        }
    }
}
