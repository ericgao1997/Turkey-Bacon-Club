using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	/*
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
*/
	bool mouseIsBeingHeld = false;
	void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        mouseIsBeingHeld = true;
    }
	void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
      	mouseIsBeingHeld = false;
    }
	void Update(){ //what the hell might as well make it a binding too
		if (Input.GetMouseButtonDown (0) && mouseIsBeingHeld) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
