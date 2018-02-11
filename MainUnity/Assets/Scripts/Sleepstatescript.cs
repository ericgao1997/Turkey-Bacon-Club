using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleepstatescript : MonoBehaviour {
	private Animator animator;
	//public int timetoswitch = 400;
	//private int sleepState;
	//private int counter;
	// Use this for initialization
	void Start () {
		//sleepState = 0;
		//counter = timetoswitch;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (hpManager.health > 8) {
			animator.SetInteger ("sleepLevel", 0);
		} else if (hpManager.health > 5) {
			animator.SetInteger ("sleepLevel", 1);
		} else if (hpManager.health > 2) {
			animator.SetInteger ("sleepLevel", 2);
		} else {
			animator.SetInteger ("sleepLevel", 3);
		}
	}
}
