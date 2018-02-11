using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurOnOff : MonoBehaviour {
	public MeshRenderer meshrend;
	//public GameObject sself;
	private int t;
	// myParent;
	// Use this for initialization
	void Start () {
		//s = setEnemyType.size;
		//myParent = transform.parent.GetComponent<setEnemyType>();
		t = this.transform.parent.GetComponent<setEnemyType>().type;
	}
	
	// Update is called once per frame
	void Update () {
		if (resChanger.level == t) {
			//hitbox.enabled = true;
			//animator.SetBool("Blur", false);
			meshrend.enabled = false;
		}
		else {
			//hitbox.enabled = false;
			//animator.SetBool("Blur", true);
			meshrend.enabled = true;
		}
	}
}
