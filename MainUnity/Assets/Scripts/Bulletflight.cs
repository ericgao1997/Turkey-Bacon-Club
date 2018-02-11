using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletflight : MonoBehaviour {

	Rigidbody2D m_Rigidbody;
	float m_Speed;
	int lifespan;
	public int level;
	static public int score =0;

	// Use this for initialization
	void Start () {
		Debug. Log("initialized");
		lifespan=5;
		m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Speed = 10f;
		level = resChanger.level;
        Destroy(gameObject, lifespan);
    }
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "isEnemy") {
			if (other.gameObject.GetComponent<setEnemyType> ().type == level) {
				score++;
				Destroy (gameObject);
			}
		}
	}
	public void move(){
        m_Rigidbody.velocity = -transform.right* m_Speed;

	}

	// Update is called once per frame
	void Update () {
        move();
	}
}
