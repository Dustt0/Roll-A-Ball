using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform lookAt;
    private Vector3 offSet;
    public float distance = 5.0f;
    public float yOffSet = 2f;

    private void Start()
    {
        offSet = new Vector3(0, yOffSet, -1f * distance);
    }

    private void Update()
    {
        transform.position = lookAt.position + offSet;
    }
   
}
