using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosecatcher : MonoBehaviour {
	private int currCatcher;
	public SpriteRenderer[] catcher;
	public Sprite[] img;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currCatcher = resChanger.level;
		for (int i = 0; i < 4; ++i) {
			if (i == currCatcher) {
				catcher [i].sprite = img [currCatcher + 1];
			}else {
				catcher [i].sprite = img [0];
			}
			//Debug.Log (i);
		}
	}
}
