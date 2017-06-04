using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loop01 : MonoBehaviour {

	public GameObject Emily;
	public GameObject Emily2;

	public GameObject EmilyTest1;
	public GameObject EmilyTest2;
	public GameObject EmilyTest3;

	public GameObject Button1;
	public GameObject Button2;
	public GameObject Button3;
	public GameObject Button4;

	public Material[] ChangingMats;
	public AudioSource[] audio;
	public Light Light1;

	public Slider musicSlider;


	//[Range(0.5f, 0.7f)]




	// Use this for initialization
	void Start () {

		//Renderer rend = Emily.gameObject.GetComponent<Renderer> ();

		MeshRenderer meshR = Emily.gameObject.GetComponent<MeshRenderer> ();
		meshR.material = ChangingMats[0];



	}
	
	// Update is called once per frame
	void Update () {


		if (Light1.intensity == 0.5f || audio[1].isPlaying /*|| audio [4].isPlaying || audio [2].isPlaying*/) {
			
			MeshRenderer meshR = Emily.gameObject.GetComponent<MeshRenderer> ();
			meshR.material = ChangingMats [1];
			 
			if (audio[1].isPlaying && (musicSlider.value >= 0.6f && musicSlider.value <= 0.8f) && Light1.intensity == 0.5f) {

				meshR.material = ChangingMats [2];
				StartCoroutine ("WaitLoop");
	
			}else if (audio[2].isPlaying && (musicSlider.value >= 0.1f && musicSlider.value <= 0.2f )&& Light1.intensity == 0.5f){

				meshR.material = ChangingMats [2];
				StartCoroutine ("WaitLoop");

			}else if (audio [4].isPlaying && musicSlider.value >= 0.8f && Light1.intensity == 0.5f){

				meshR.material = ChangingMats [2];
				StartCoroutine ("WaitLoop");
	
			}

		

		} else if (Light1.intensity == 0f) {
			MeshRenderer meshR = Emily.gameObject.GetComponent<MeshRenderer> ();
			meshR.material = ChangingMats [0];
		}

		if(Light1.intensity == 1f){

			MeshRenderer meshR = Emily.gameObject.GetComponent<MeshRenderer> ();
			meshR.material = ChangingMats[3];

		}


	}

	IEnumerator WaitLoop (){
		yield return new WaitForSeconds (3f);
		Emily.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		Emily2.SetActive (true);
		EmilyTest1.SetActive (true);
		EmilyTest2.SetActive (true);
		EmilyTest3.SetActive (true);
		Button1.SetActive (true);
		Button2.SetActive (true);
		Button3.SetActive (true);
		Button4.SetActive (true);

	}
}
