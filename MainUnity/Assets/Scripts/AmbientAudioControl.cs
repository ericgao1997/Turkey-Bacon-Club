using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioControl : MonoBehaviour {
	public AudioSource Ambience;
	public AudioSource Breathing;
	public AudioSource Heartbeat;
	public AudioSource Dreamcatcher;
	private int frame = 0;
	// Use this for initialization
	void Start () {
		Dreamcatcher.PlayDelayed (4f);
		Ambience.volume = 0.5f;
		Breathing.volume = 0.1f;
		Heartbeat.volume = 0.2f;
		Dreamcatcher.volume = 0.7f;
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (hpManager.health < 2) {
			Dreamcatcher.volume = 0.2f;
			Breathing.volume = 0.9f;
			Heartbeat.volume = 0.9f;
		} else if (hpManager.health < 3) {
			Dreamcatcher.volume = 0.3f;
			Breathing.volume = 0.7f;
			Heartbeat.volume = 0.7f;
		} else if (hpManager.health < 5) {
			Dreamcatcher.volume = 0.4f;
			Breathing.volume = 0.5f;
			Heartbeat.volume = 0.5f;
		} else if (hpManager.health < 7) {
			Dreamcatcher.volume = 0.5f;
			Breathing.volume = 0.3f;
			Heartbeat.volume = 0.5f;
		} else if (hpManager.health < 9) {
			Dreamcatcher.volume = 0.6f;
			Breathing.volume = 0.2f;
			Heartbeat.volume = 0.3f;
		}

		//if (frame == 60)
		//	Dreamcatcher.Play ();
	}
}
