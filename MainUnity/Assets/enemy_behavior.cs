using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_behavior : MonoBehaviour {
    Vector3 Target = new Vector3(0, 0, 2);
    public float speed;
    private SpriteRenderer SpriteRend;
    // Use this for initialization
    void Start () {
        SpriteRend = GetComponent<SpriteRenderer>();
        if (transform.position.x <= Target.x )
        {
            SpriteRend.flipX = false;
        }
        else
        {
            SpriteRend.flipX = true;
        }
        speed = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, Target, speed);
         
    }
}
