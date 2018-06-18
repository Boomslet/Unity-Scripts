using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	[Header("Timer Prefab")]
	public Text timerText;
	
	[Header("Timer Duration")]
	public float endGameTimer = 15.00f;
	
	private float timer = 0f;

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timerText.text = timer.ToString("00.00");
		
		if (timer >= endGameTimer) 
		{
			/* TODO */
		}
	}
}
