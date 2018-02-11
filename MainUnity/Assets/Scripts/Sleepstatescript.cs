using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleepstatescript : MonoBehaviour {
	private Animator animator;
	public int timetoswitch = 400;
	private int sleepState;
	private int counter;
	// Use this for initialization
	void Start () {
		sleepState = 0;
		counter = timetoswitch;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (counter!=0) {
			counter--;
		} else {
			sleepState = (sleepState + 1) % 4;
			animator.SetInteger("sleepLevel", sleepState);
			counter = timetoswitch;
		}
	}
}
