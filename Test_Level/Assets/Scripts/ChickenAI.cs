using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	public Rigidbody enemy;
	private float moveSpeed = 6f;
	public Transform target;
	public Transform chickenPen;
	private float timer;
	public int points = 10;

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			//Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
			
			}

	}

        
    

    void OnCollisionEnter(Collision other){
        if(other.gameObject.name == "Player"){
            /*Destroy(gomaObgject); */
            ScoreManager.AddPoints(points);
            transform.position = chickenPen.position;
            transform.rotation = chickenPen.rotation;


        }
    }

}
