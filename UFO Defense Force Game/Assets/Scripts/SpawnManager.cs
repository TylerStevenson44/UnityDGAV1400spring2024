using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pickup;
    public float spawnRangeX;
    public float spawnPosZ;
    public float spawnPosY;
    public float startDelay;
    public float spawnInterval;

    
    // Start is called before the first frame update
    void Start()
    {
        //spawn the pickup repeatedly when our game starts.
        InvokeRepeating("SpawnPickup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPickup()
    {
        //spawn our pickup within the range we determine
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(pickup, spawnPos, pickup.transform.rotation);


    }
}

