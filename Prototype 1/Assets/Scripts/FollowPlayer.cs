using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // GameObject player needs to be public since it is referenced by the camera
    public GameObject player;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
