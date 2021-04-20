using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnXRange = 12.0f;
    private float spawnZRange = 15.0f;

    //I can make them spawn at 3 snapped locations now!
    private float[] spawnRangeX = {12.0f, 0, -12.0f };

    //spawn delay
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    void SpawnAnimals()
        {
            //Random Animals
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            int spawnIndex = Random.Range(0, spawnRangeX.Length);
            Vector3 spawn = new Vector3(Random.Range(spawnXRange, -spawnXRange), 0, spawnZRange);

            Instantiate(animalPrefabs[animalIndex], spawn, animalPrefabs[animalIndex].transform.rotation);
        }
}
