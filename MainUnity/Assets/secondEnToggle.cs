using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondEnToggle : MonoBehaviour {

	public BoxCollider hitbox;
	public MeshRenderer mesh;

	// Use this for initialization
	void Start () { //off at start
		hitbox.enabled = false;
		mesh.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (2);
		if (resChanger.level == 2) {
			hitbox.enabled = true;
			mesh.enabled = true;
		}
		else {
			hitbox.enabled = false;
			mesh.enabled = false;
		}
	}
}
