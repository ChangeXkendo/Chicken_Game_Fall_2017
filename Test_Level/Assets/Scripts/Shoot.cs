﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Rigidbody projectile;
	public Transform shootPoint;
	public int shootSpeed;

	// Use this for initialization
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, shootPoint.position, projectile.rotation);
			
			clone.velocity = shootPoint.TransformDirection(Vector3.forward*shootSpeed);
		}
	}
}	
	// Update is called once per frame