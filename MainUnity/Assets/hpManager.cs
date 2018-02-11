using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpManager : MonoBehaviour {

	static public int health=100; //default 100

	// Use this for initialization
	void Start () {}

	void OnCollisionEnter(Collision col){
		if (col.collider.name == "Enemy") {
			health -= 1;
		}
		if (health <= 0) {
			FindObjectOfType<gameOver>().endGame();
		}
	}
}
