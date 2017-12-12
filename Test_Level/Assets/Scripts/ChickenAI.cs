using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour
{
    public Rigidbody enemy;
    private float moveSpeed = 33f;
    public Transform target;
    public Transform chickenPen;
    private float timer;
    public int points = 10;
    public GameObject chicken;
    public bool withinBounds;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            withinBounds = true;
            //Debug.Log("Player has entered chickens trigger");
            transform.LookAt(target);
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            


        }
        

    }




    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
         
            /*Destroy(gomaObgject); */
            ScoreManager.AddPoints(points);
            transform.position = chickenPen.position;
            transform.rotation = chickenPen.rotation;


        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            chicken.GetComponent<Wander03>().enabled = true;

        }
    }
    void Update()
        {
            if (withinBounds == true)
            {
                chicken.GetComponent<Wander03>().enabled = false;
            }
            else
            {
                chicken.GetComponent<Wander03>().enabled = true;
                
            }
            withinBounds = false;
        }
    }

