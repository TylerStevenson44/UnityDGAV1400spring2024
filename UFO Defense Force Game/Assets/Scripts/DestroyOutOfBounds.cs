using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 60.0f;
    public float bottomBounds = -50.0f;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        //destoy game objects that go above this top bound
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        //destroy game objects that go below the bottom bound
        if (transform.position.z < bottomBounds && !gameObject.CompareTag("Pickup"))
        {
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }
        if (transform.position.z < bottomBounds && gameObject.CompareTag("Pickup"))
        {
            Destroy(gameObject);
        }
    }

}
