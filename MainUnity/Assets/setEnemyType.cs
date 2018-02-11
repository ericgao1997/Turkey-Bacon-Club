﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setEnemyType : MonoBehaviour {
	private Animator animator;
	static public int nextEnType = 0;//0-3
	static public int nextEnSize = 2;//1-3
	public int size;
	public int type;
	//private Vector3 scale;
	Vector3 Target = new Vector3(0, 0, 0);
	public float speed;
	private SpriteRenderer SpriteRend;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		//animator.SetBool("Blur", true);
		size = nextEnSize;
		type = nextEnType;
		animator.SetInteger("Enemynum",type);
		Vector3 scale = new Vector3(size, size, 1);
		transform.localScale = scale;
		SpriteRend = GetComponent<SpriteRenderer>();
		if (transform.position.x <= Target.x )
		{
			SpriteRend.flipX = false;
		}
		else
		{
			SpriteRend.flipX = true;
		}
		speed = 0.05f/(size);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, Target, speed);
		//transform.position = transform.position + Target;
		//Debug.Log ("position is " + transform.position);
		if (false) {
			animator.Play ("death");
		}
	}
}
