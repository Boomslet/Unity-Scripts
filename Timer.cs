using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	//ingame text for your timer
	public Text timerText;
	private float startTime;
	public float endGameTime = 15.00f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");
		timerText.text = minutes + ":" + seconds;
		if (t >= endGameTime) 
		{
			// Your Condition
		}
	}
}
