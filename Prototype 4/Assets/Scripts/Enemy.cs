using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        // refer to our game components
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // have our enemy look towards our  player and apply a force in that direction
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        // destroy enemies off stage so we can start the next wave
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
