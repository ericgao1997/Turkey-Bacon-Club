using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletflight : MonoBehaviour {

	Rigidbody2D m_Rigidbody;
	float m_Speed;
	int lifespan;

	// Use this for initialization
	void Start () {
		Debug. Log("initialized");
		lifespan=50;
		m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Speed = 1f;
	}
	Vector3 heading = new Vector3(0.1f,0.1f,0);

	public void move(){
		// transform.Translate(-transform.right * Time.deltaTime * m_Speed);
		if (lifespan > 0){
			transform.position += heading;
			lifespan-=1;
		} else {
			//this.renderer.enabled = false;
			GetComponent<Renderer>().enabled = false;
			Destroy(this);
		}
	}

	// Update is called once per frame
	void Update () {
		print("cheese");
		//no collision case
		if (lifespan > 0){
			//transform.position += heading;
			lifespan-=1;
		} else {
			//this.renderer.enabled = false;
			GetComponent<Renderer>().enabled = false;
			Destroy(this);
		}
		
	}
}
