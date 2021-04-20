using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = 7.0f;
    private float spawnLimitXRight = -20.0f;
    private float spawnPosY = 30;

    private float startDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        float intervals = Random.Range(3.0f, 5.0f);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, -1.5f);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        //next ball
        Invoke(nameof(SpawnRandomBall), intervals);
    }

}
