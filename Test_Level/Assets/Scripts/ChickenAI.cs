using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform target2;
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
			
			}
			if(other.gameObject.name == "Wolf"){
			Debug.Log("Wolf has entered chickens trigger");
			transform.LookAt(target2);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
			}
		}



	}
	
		
	

