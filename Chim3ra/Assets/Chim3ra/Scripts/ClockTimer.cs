using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClockTimer : MonoBehaviour {

	public Text counterText;

	public float seconds, minutes;

	public float timeSpeed = 1f;

	// Use this for initialization
	void Start () {
		counterText = GetComponent<Text> () as Text;
		minutes = 9f;

	}
	
	// Update is called once per frame
	void Update () {
		minutes = 9 + (int)(Time.time / 60f);
		seconds = (int)(Time.time % 60f ) * timeSpeed;
		counterText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00"); 

		if (minutes >= 16) {
			Debug.Log("Ende");
			SceneManager.LoadScene ("Startscreen");

		}

	}
}
