using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statechange : MonoBehaviour {

	private Animator animator;
	public SpriteRenderer myspr;
	public int state;

	// Use this for initialization
	void Start () {
		state = 0;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (resChanger.level == 1) {
			state = 1;
			animator.SetBool ("isBlur", false);
			//myspr.enabled = true;
		} else {
			//myspr.enabled = false;
			state = 0;
			animator.SetBool ("isBlur", true);
		}
	}
}
