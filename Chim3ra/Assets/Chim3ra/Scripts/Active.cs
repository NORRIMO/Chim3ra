using System.Collections;
using UnityEngine;

public class Active : MonoBehaviour {


	public GameObject text01;
	public GameObject text02;
	public GameObject text03;
	public GameObject text04;
	public GameObject text05;
	public GameObject StartHack;
	public GameObject Traffic;


	void Start(){
		
		StartCoroutine ("activeText");
		
	}
	// Use this for initialization

	
	IEnumerator activeText() {
		
		yield return new WaitForSeconds (1f);
		text01.SetActive (true);
		yield return new WaitForSeconds (1.5f);
		text02.SetActive (true);
		yield return new WaitForSeconds (1f);
		text03.SetActive (true);
		yield return new WaitForSeconds (1.5f);
		text04.SetActive (true);
		yield return new WaitForSeconds (2f);
		text05.SetActive (true);
		yield return new WaitForSeconds (2.5f);
		StartHack.SetActive (false);
		Traffic.SetActive (true);
	}


}
