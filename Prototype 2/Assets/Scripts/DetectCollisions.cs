using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // function for using our collider boxes and body
    private void OnTriggerEnter(Collider other)
    {
        //function removes both the food object and the animal object from the playing field.
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
