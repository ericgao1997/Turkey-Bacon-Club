using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behaviourofmiddleblob : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log ("Shooter Object initiated");
        Debug.Log (transform.position.x);
        Debug.Log (transform.position.y);
	}

	void CwT(){
		Debug.Log("turning clockwise");
		Vector3 temp = new Vector3(1.0,0.0,0.0);
		transform.position.x += temp;
	}

	void CCwT(){
		Debug.Log("turning counterclockwise");
		Vector3 temp = new Vector3(-1.0,0.0,0.0);
		transform.position.x += temp;
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
		if (Input.GetKey("d")){
			CwT();
		}
		if (Input.GetKey("a")){
			CCwT();
		}
		if (Input.GetKeyDown("w")){
			Change_Resolution(1);
		}
		if (Input.GetKeyDown("s")){
			Change_Resolution(-1);
		}
	}


}
