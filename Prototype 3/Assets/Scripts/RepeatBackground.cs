using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // make our variables for our code
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        // make sure our repeat of the background is the same every time
        startPos = transform.position;
        // use the box collider to check the exact size and devide it by 2 so our backgrround repeats perfectly without having to do trial and error
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // this if statement tells the game when to place the background back to its original position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
