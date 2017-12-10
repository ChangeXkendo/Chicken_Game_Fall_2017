using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Transform target;
	public float moveSpeed;

	public int damage;
	public GameObject pcHealth;


	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	
	}

	void OnCollisionEnter(Collision other)
	{
	
		if(other.gameObject.name == "Player"){
		var hit = other.gameObject;
		//var health = hit.GetComponent<playerHealth>();
		print("Wolf is attacking!");

		if(pcHealth != null){
			
			//pcHealth.TakeDamage(damage);
			pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
     }
 	}
   } 
  }
