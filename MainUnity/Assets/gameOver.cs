using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public void endGame(){
		
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("Game Over");
			//restart game
			Invoke("Restart", restartDelay);
		}

	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
