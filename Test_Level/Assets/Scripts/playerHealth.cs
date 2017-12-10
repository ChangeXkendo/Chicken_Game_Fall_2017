using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = 100;
	public Text hp;
	public Text maxHP;
    public GameObject player;
    

    private void Start()
    {
        hp.GetComponent<Text>();
        
       
    }
    
    
    void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
		
	}
	public void TakeDamage(int amount){
		currentHealth = currentHealth - amount;
		if(currentHealth <= 0){
			currentHealth=0;
			print("You're Dead! Game Over!");
            player.GetComponent<PlayerMove>().enabled = false;
            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		}

	}
}

