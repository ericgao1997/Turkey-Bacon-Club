using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdEnToggle : MonoBehaviour {

	public BoxCollider hitbox;
	public MeshRenderer mesh;

	// Use this for initialization
	void Start () { //off at start
		hitbox.enabled = false;
		mesh.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (3);
		if (resChanger.level == 3) {
			//Debug.Log (resChanger.level);
			hitbox.enabled = true;
			mesh.enabled = true;
		}
		else {
			hitbox.enabled = false;
			mesh.enabled = false;
		}
	}
}
