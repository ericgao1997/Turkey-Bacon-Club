using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float startx, starty;
	public float steps; //bigger more smaller less (steps) 

	//ONLY EVER ADJUST STEPS IN GUI

	//steps per update
	public int quadrant; //1 to 4
	static public bool reached=false; 

	// Use this for initialization
	void Start () {
		startx = transform.position [0];
		starty = transform.position [1];
		if (startx >= 0 && starty >= 0) {
			quadrant = 1;
		} else if (startx < 0 && starty >= 0) {
			quadrant = 2;
		} else if (startx < 0 && starty < 0) {
			quadrant = 3;
		} else if (startx >= 0 && starty < 0) {
			quadrant = 4;
		}
		//steps = 1.5f;
	}

	//(0,0,2) is center
	// Update is called once per frame
	void Update () {
		//all monsters of same type move same speed!

		//x-axis
		if (quadrant == 1 || quadrant == 4) {
			if (transform.position [0] > 0) {
				Vector3 temp = new Vector3 (steps,0,0);
				transform.position -= temp;
			} else {
				reached = true;
			}
		}
		else{
			if (transform.position [0] < 0) {
				Vector3 temp = new Vector3 (steps,0,0);
				transform.position += temp;
			} else {
				reached = true;
			}
		}

		//y-axis
		if (quadrant == 1 || quadrant == 2) {
			if (transform.position [1] > 0) {
				Vector3 temp = new Vector3 (0,steps,0);
				transform.position -= temp;
			} else {
				reached = true;
			}
		}
		else{
			if (transform.position [1] < 0) {
				Vector3 temp = new Vector3 (0,steps,0);
				transform.position += temp;
			} else {
				reached = true;
			}
		}
		
	}
}
