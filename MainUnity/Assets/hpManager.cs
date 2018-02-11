using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpManager : MonoBehaviour {

	static public int health = 1; //default 10

	// Use this for initialization
	void Start () {}

	void Update(){
		if (health <= 0) {
			FindObjectOfType<gameOver>().endGame();
		}
	}
}
