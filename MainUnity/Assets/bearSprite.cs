using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearSprite : MonoBehaviour {
	public GameObject follow;
	public Sprite up;
	public Sprite left;
	public Sprite down;
	public Sprite right;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		transform.position = follow.transform.position;
		spriteRenderer = GetComponent<SpriteRenderer>();
		// Sprite bum = Resources.Load("Bear/bearBack")as Sprite;
		// Sprite face = Resources.Load("Bear/bearFront")as Sprite;
		// Sprite ring = Resources.Load("Bear/bearRight")as Sprite;
		// Sprite leg = Resources.Load("Bear/bearLeft") as Sprite;
	}
	// Does this help?
	// Update is called once per frame
	void Update () {
		transform.position = follow.transform.position;
		transform.Translate(0f, 1f, 0f);
		float wut = follow.transform.eulerAngles.z;
		// print(wut);
		if (wut >= 45 && wut <135){
			// GetComponent(SpriteRenderer).sprite = ring;
			spriteRenderer.sprite = left;
			print("right");
		}
		else if (wut >= 135 && wut < 225){
			// GetComponent(SpriteRenderer).sprite = face;
			spriteRenderer.sprite = down;
			print("down");
		}
		else if (wut >= 225 && wut < 315){
			// GetComponent(SpriteRenderer).sprite = leg;
			spriteRenderer.sprite = right;
			print("left");
	 	}
		else{
			// GetComponent(SpriteRenderer).sprite = bum;
			spriteRenderer.sprite = up;
			print("up");
		}
	}
}
