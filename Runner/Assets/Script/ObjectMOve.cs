using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMOve : MonoBehaviour
{
    private float moveSpeed = 5f;
    private bool moveForward = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 2f)
            moveForward = false;
        if (transform.position.z < -2f)
            moveForward = true;

        if (moveForward)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveSpeed * Time.deltaTime);
    }
    
}
