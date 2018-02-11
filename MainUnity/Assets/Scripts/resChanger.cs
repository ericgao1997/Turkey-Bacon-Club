using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resChanger : MonoBehaviour {

	static public int level;

	//flat area is z=2

	// Use this for initialization
	void Start () {
		level = 0; //1 to 3
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("w")){
			level += 3;
			level %= 4;
		}

		if (Input.GetKeyDown ("s")) {
			level += 1;
			level %= 4;
		}

		//Debug.Log (level);
	}
}
