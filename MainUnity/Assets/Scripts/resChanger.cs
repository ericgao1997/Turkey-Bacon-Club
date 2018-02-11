using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resChanger : MonoBehaviour {

	static public int level;

	//flat area is z=2

	// Use this for initialization
	void Start () {
		level = 3; //1 to 3
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("w")){
			if (level < 3)
				level += 1;
			else
				;
		}

		if (Input.GetKeyDown ("s")) {
			if (level > 1)
				level -= 1;
			else //elif level == 0
				;
		}

		//Debug.Log (level);
	}
}
