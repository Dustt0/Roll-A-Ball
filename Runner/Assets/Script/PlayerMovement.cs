using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Touch touch;
    public Text collectiblesObject;
    public float sSpeed;
    public float fSpeed;
    public GameObject Player;

    private Rigidbody rb;

    public static int numOfCollectors;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        numOfCollectors = 0;
    }
    void Update()
    {
        //transform.Translate(Vector3.forward * fSpeed * Time.deltaTime);
        rb.velocity = new Vector3(0, 0, fSpeed);
        

        if (Input.touchCount > 0 /*&& Input.GetTouch(0).phase == TouchPhase.Stationary*/)
        {

            Vector3 touchPosition = Input.GetTouch(0).position;

            double halfScreen = Screen.width / 2.0;




            //Check if it is left or right?
            if (touchPosition.x < halfScreen )
            {
                Player.transform.Translate(Vector3.left * sSpeed * Time.deltaTime);
            }
            else if (touchPosition.x > halfScreen )
            {
                Player.transform.Translate(Vector3.right * sSpeed * Time.deltaTime);
            }
            
        }
        collectiblesObject.text = "Objects: " + numOfCollectors;
    }


    public void SetSpeed(float modifier)
    {
        fSpeed += modifier;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obsticles")
        {
            
            fSpeed = 0;
            FindObjectOfType<GameManager>().Death();
               
        }
    }

    

}







