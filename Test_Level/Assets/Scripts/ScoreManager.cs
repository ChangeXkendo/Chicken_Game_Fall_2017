using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public Text text;
	
	public Text winText;
	public int winScore;

	// Use this for initialization
	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
			score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
		score = 0;

		text.text = " " + score;
		// If the player win Display win text

			if(winScore == score){
			print("Win Score Reached" + score);
			winText.GetComponent<Text>().enabled = true;
		
	}
	// if(Input.GetKeyDown("Esc")){
	// 	ScoreManager.LoadScene(0);
	// }

}

	public static void AddPoints (int pointsToAdd){
	score += pointsToAdd;

	}
	public void Reset(){
	score = 0;
	}
}


