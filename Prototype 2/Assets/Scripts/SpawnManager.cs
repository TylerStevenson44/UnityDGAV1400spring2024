using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // an array to hold our animal prefabs
    public GameObject[] animalPrefabs;
    // variables for our functions
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // starts the game 
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void SpawnRandomAnimal()
    {
        // int animalIndex is within this funcion so its only called within the function.
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // spawn a random animal prefab from our array within the positions from spawnPos
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
