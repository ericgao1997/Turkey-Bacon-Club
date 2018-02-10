using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehaviour : MonoBehaviour {

	public float offset = 0.0f;
	public double angel = 0.0f;
	// Use this for initialization
	void Start () {
		//item should start at (0,5,2)
		angel = 0.0f;
		transform.position = new Vector3(	(float)(5*System.Math.Cos(angel)), 	(float)(5*System.Math.Sin(angel)), 	0);
	}
	
	void Turn(int x){
		angel = angel + x*0.05;
		//double newangle = angle + x*0.05;

		//assuming that the turn radius is 5
		transform.position = new Vector3(	(float)(5*System.Math.Cos(angel)), 	(float)(5*System.Math.Sin(angel)), 	0);
	}

	void Change_Resolution(int i){
		if (i == -1){
			Debug.Log("Changing resolution Down");
		}
		if (i == 1){
			Debug.Log("Changing resolution Up");
		}
		
	}
	
	void Follow_Mouse(){
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset - 90);
	}

	void Shoot(){
		//Instantiate(Bullet_0, this.transform.position, this.transform.rotation);
	}

	void ShootSpecial(){
		//stuff
	}

	// Update is called once per frame
	void Update () {

		//computes angle wrt origin
		//double angle = System.Math.Atan((transform.position.y)/(transform.position.x));

		Follow_Mouse();

		//listens to inputs
		if (Input.GetKey("d")){
			Turn(1);
		}
		if (Input.GetKey("a")){
			Turn(-1);
		}
		if (Input.GetKeyDown("w")){
			Change_Resolution(1);
		}
		if (Input.GetKeyDown("s")){
			Change_Resolution(-1);
		}
		if (Input.GetMouseButtonDown(0)){	//leftmouse click
			Shoot();
		}
		if (Input.GetMouseButtonDown(1)){
			ShootSpecial();
		}
	}

}
