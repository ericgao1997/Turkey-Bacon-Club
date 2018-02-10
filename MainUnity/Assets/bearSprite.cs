using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearSprite : MonoBehaviour {
	public GameObject follow;
	// Use this for initialization
	void Start () {
		transform.position = follow.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = follow.transform.position;
	}
}
