using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public int startDelay = 2;
    public int spawnPosX;
    public int spawnRangeY;
    private int spawnPosZ = 0;
    public float spawnInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, Random.Range(1, spawnInterval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstacles.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY), spawnPosZ);

        // spawn a random animal prefab from our array within the positions from spawnPos
        Instantiate(obstacles[obstacleIndex], spawnPos, obstacles[obstacleIndex].transform.rotation);
    }
}
