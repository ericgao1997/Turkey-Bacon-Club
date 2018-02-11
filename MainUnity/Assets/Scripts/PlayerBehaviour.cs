using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehaviour : MonoBehaviour {
	public float offset = 0.0f;
	public double angel = 0.0f;
	public GameObject bulletPrefab;
	private int delayyyyy = 0;

	// public List<GameObject> bulList = new List<GameObject>();
	// public List<int> del = new List<int>();
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

	float rotation_z;
	void Follow_Mouse(){
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset - 90);
	}

	void Shoot(){
		if (delayyyyy==0){
			delayyyyy = 10;
			var bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
	        bullet.transform.rotation = Quaternion.Euler(0, 0, rotation_z - 180); 
		}
        // Destroy(bullet, 3.0f);
	}
	// void pewdate(){
	// 	foreach (GameObject bulit in bulList)
	// 	{
	// 		print("shifting bulit");
	// 		bulit.transform.position = bulit.transform.forward*0.1f;
	// 	}
	// }
	void ShootSpecial(){
		//stuff
	}

	// Update is called once per frame
	void Update () {

		//computes angle wrt origin
		//double angle = System.Math.Atan((transform.position.y)/(transform.position.x));
		if (delayyyyy > 0) {
			delayyyyy--;
		}
		Follow_Mouse();

		if (Input.GetKey("d") || Input.GetKey("a")){
			if (Input.GetKey("d")){ Turn(1); }
			if (Input.GetKey("a")){ Turn(-1); }
			
		}

		if (Input.GetMouseButtonDown(0)){	//leftmouse click
			Shoot();
		}
		// pewdate();
	}

}
