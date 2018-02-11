using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credsS : MonoBehaviour {
	public Sprite gmov;
	public Sprite credits;
	// Use this for initialization
	public GameObject display;
	private SpriteRenderer spR;
	bool check = true;
	void Start () {
		spR = display.GetComponent<SpriteRenderer>();
	}
	bool mouseIsBeingHeld = false;
	void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        mouseIsBeingHeld = true;
    }
	void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
      	mouseIsBeingHeld = false;
    }
	void Update(){ //what the hell might as well make it a binding too

		if (Input.GetMouseButtonDown (0) && mouseIsBeingHeld) {
			if (check == false){
				check = true;
				spR.sprite = gmov;
			}
			else{
				check = false;
				spR.sprite = credits;
			}
		}
	}
}
