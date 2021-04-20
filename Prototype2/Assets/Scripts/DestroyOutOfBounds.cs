using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float outOfBoundTop = 35.0f;
    private float outOfBoundBottom = -4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroy food
        if (transform.position.z > outOfBoundTop)
        {
            Destroy(gameObject);
        }

        //destroy animal
        else if (transform.position.z < outOfBoundBottom)
        {
            Debug.Log("Game Over!!");
            Destroy(gameObject);
        }
    }
}
