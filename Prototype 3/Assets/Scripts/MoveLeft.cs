using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerContorllerScript;
    private float leftBound = -25;
    // Start is called before the first frame update
    void Start()
    {
        // refer to our playercontroller script
        playerContorllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // keeps our  game moving so long as we are winning
        if (playerContorllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //removes excess objects that are no longer in the sceene
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
           Destroy(gameObject);
        }
    }
}
