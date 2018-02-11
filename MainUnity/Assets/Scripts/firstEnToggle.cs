using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstEnToggle : MonoBehaviour {

	//public BoxCollider hitbox;

	public int currentLevel;

	// Use this for initialization
	void Start () { //off at start
		//hitbox.enabled = false;
		GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (1);
		if (resChanger.level == currentLevel) {
			//hitbox.enabled = true;
			GetComponent<Renderer> ().enabled = true;

		}
		else {
			//hitbox.enabled = false;
			GetComponent<Renderer>().enabled = false;
		}
	}
}
