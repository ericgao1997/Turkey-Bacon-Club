using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	bool gameHasEnded = false;

	public void endGame(){
		
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("Game Over");
			//restart game
			Restart();
		}

	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
