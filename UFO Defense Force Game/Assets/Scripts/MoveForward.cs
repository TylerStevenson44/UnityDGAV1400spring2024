using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 50.0f;



    // Update is called once per frame
    void Update()
    {
        // move game object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
