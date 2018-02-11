using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour {

	/*
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		SceneManager.LoadScene ("Main");
	}
	*/

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log ("Test");
			SceneManager.LoadScene("Main"); //gotta build the app with both scenes(s)
		}
	}
}
