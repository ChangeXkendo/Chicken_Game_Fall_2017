using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Transform target;
	public Transform target2;
	public float moveSpeed;
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered Wolf's Trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		if(other.gameObject.name == "Chicken"){
			Debug.Log("Chicken has entered Wolf's Trigger");
			transform.LookAt(target2);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}

}
