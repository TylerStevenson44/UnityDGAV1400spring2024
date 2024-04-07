using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //serialize field for access to edit private varables within inspector
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 6.5f;
    //set our input floats for movement
    [SerializeField] private float verticalInput;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalSpeed;
    [SerializeField] private float horizontalSpeed;
    //make our rigidbody a variable
    private Rigidbody playerRb;
    //make our isJumping bool a variable
    private bool isJumping;



    // Start is called before the first frame update
    void Start()
    {
        // use a rigidbody for gravity 
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //attempt mouse camera movement.
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up, h * horizontalSpeed * Time.deltaTime);

        //assign our floats buttons 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move our character around with our inputs
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);

        //make our character jump with space and if isJumping is fase
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isJumping set to true to prevent a double jump
            isJumping = true;
        }
        //sprint on left shift hold
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // mutiply movement speed by 2 when shift key is pressed
            moveSpeed *= 2;
        }
        if  (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //devide it by 2 again when its not pressed to return it to normal
            moveSpeed /= 2;
        }
    }
    // use the onCollisionEnter method to detect collision with the floor
    private void OnCollisionEnter(Collision collision)
    {
        //if we collide with a game object (floor or wall) our is jumping bool gets set back to false
        if (collision.gameObject)
        {
            isJumping = false;
        }
    }
}
