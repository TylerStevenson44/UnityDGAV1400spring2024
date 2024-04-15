using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store UFO ships

    private float spawnRangeX = 60f;

    private float spawnPosZ = 50f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // get a random ufo from our array and use the array length so no matter how many are in the array it always uses the right amount.
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);
        // spawn one of our indexed UFOs from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }
}
 