using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//item should start at (0,5,2)
	}
	
	void Turn(double angle, int x){

		double newangle = angle + x*0.05;

		//assuming that the turn radius is 5
		transform.position = new Vector3(	(float)(5*System.Math.Cos(newangle)), 	(float)(5*System.Math.Sin(newangle)), 	0);
	}

	void Change_Resolution(int i){
		if (i == -1){
			Debug.Log("Changing resolution Down");
		}
		if (i == 1){
			Debug.Log("Changing resolution Up");
		}
		
	}
	

	// Update is called once per frame
	void Update () {

		//computes angle wrt origin
		double angle = System.Math.Atan((transform.position.y)/(transform.position.x));

		//listens to inputs
		if (Input.GetKey("d")){
			Turn(angle, 1);
		}
		if (Input.GetKey("a")){
			Turn(angle, -1);
		}
		if (Input.GetKeyDown("w")){
			Change_Resolution(1);
		}
		if (Input.GetKeyDown("s")){
			Change_Resolution(-1);
		}
	}

}
