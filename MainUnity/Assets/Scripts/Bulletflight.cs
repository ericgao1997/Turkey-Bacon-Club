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
		lifespan=10;
		m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Speed = 10f;

        Destroy(gameObject, lifespan);
    }

	public void move(){
        m_Rigidbody.velocity = -transform.right* m_Speed;

	}

	// Update is called once per frame
	void Update () {
        move();
	}
}
