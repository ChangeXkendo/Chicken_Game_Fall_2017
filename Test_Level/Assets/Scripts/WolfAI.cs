using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Transform target;
	public float moveSpeed;

	public int damage;


	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered Wolf's Trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			//playerHealth.TakeDamage(damage);

		}
		print("wolf is attacking!");
		var hit = other.gameObject;
		var health = hit.GetComponent<playerHealth>();

		if(health != null){
			health.TakeDamage(damage);
		}
	}
	

}
