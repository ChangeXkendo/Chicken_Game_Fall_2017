using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	public int points;

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			//keep score at zero
			currentHealth = 0;
			print("Wolf is Dead!");
			//Add points to score for killing the wolf
			ScoreManager.AddPoints(points);
			//Move Wolf to Spawn piont for restart
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			//Reset Wolf Health
			currentHealth = maxHealth;
		} 
	}

}
