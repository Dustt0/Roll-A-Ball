using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float moveSpeed = 1.5f;
    
    private bool moveRight = true;
   
    void Update()
    {
        if (transform.position.x > 2.3f)
            moveRight = false;
        if (transform.position.x < -2.3f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y,  transform.position.z);
        else
            transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);


    }
}
