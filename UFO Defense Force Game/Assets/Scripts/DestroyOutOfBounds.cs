using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 50.0f;
    public float bottomBounds = -50.0f;
    // Start is called before the first frame update
    void Awake()
    {
        //Time.timeScale = 1.0f;
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
        else if (transform.position.z < bottomBounds)
        {
            Destroy(gameObject);
        }
    }
}