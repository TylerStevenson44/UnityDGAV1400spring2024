using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // variables for our update function
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // deletes our exess food that we miss the animals with (i never miss though ;3)
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // deletes animals that get past and tells us we are bad at the game >:c
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("lol u succ heeheh xD ;3c  >///< try again!!! uwu");
            Destroy(gameObject);
        }
    }
}
