using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 20.0f;
    public float xRange = 13;

    //snapped player controls
    private float[] xRangePlayer = { 12.0f, 0, -12.0f };

    //food projectile
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //PLayer Control Original

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        /*
        //Player control Modified to snap
        transform.Translate(Vector3.right, horizontalInput * xRangePlayer * Time.deltaTime);
        */


        //food throw
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
    }
}
