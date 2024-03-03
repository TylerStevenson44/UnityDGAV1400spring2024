using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // GameObject player needs to be public since it is referenced by the camera
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
