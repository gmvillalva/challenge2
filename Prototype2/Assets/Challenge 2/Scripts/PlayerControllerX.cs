using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnDelay = 1.5f;
    private bool dogSpawn = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawn == false)
        {
            dogSpawn = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            //allow for next dog
            Invoke("moreDogs" , spawnDelay);
        }
    }

    void moreDogs()
    {
        dogSpawn = false;
    }
}
