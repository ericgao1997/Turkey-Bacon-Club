using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearSprite : MonoBehaviour {
	public GameObject follow;
	static public bool bang = false;

	private Sprite up;
	private Sprite left;
	private Sprite down;
	private Sprite right;
	private SpriteRenderer spriteRenderer;
	private int delay = 10;
	private int timer = 0;

	// Use this for initialization
	void Start () {
		transform.position = follow.transform.position;
		spriteRenderer = GetComponent<SpriteRenderer>();


		up = Resources.Load<Sprite>("bearBack")as Sprite;
		down = Resources.Load<Sprite>("bearFront")as Sprite;
		right = Resources.Load<Sprite>("bearRight")as Sprite;
		left = Resources.Load<Sprite>("bearLeft") as Sprite;
	}
	// Does this help?
	// Update is called once per frame
	void Update () {
		transform.position = follow.transform.position;
		transform.Translate(0f, 0.5f, 0f);
		if (Input.GetButtonDown("Fire1")){
			bang = true;
			print("true");
			timer = 0;
			up = Resources.Load<Sprite>("shotUp")as Sprite;
			down = Resources.Load<Sprite>("shotDown")as Sprite;
			right = Resources.Load<Sprite>("shotRight")as Sprite;
			left = Resources.Load<Sprite>("shotLeft") as Sprite;
		}else{
			bang = false;
			print("false");
			if (timer == delay) {
				timer = 0;
				up = Resources.Load<Sprite>("bearBack")as Sprite;
				down = Resources.Load<Sprite>("bearFront")as Sprite;
				right = Resources.Load<Sprite>("bearRight")as Sprite;
				left = Resources.Load<Sprite>("bearLeft") as Sprite;
			}else {
				timer++;
			}
		}
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
