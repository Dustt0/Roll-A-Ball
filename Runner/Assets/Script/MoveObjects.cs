using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    private float moveSpeed = 1.5f;
    
    private bool moveUp = true;
   
    void Update()
    {
        if (transform.position.x < 2.3f)
            moveUp= false;
        if (transform.position.x > -2.3f)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveSpeed * Time.deltaTime);


    }
}
