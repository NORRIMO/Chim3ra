using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour {


	public SkinnedMeshRenderer SMRenderer;


	// Use this for initialization
	void Start () {


		SMRenderer.enabled = false;
			
	}

	void OnTriggerEnter(Collider col) {
		
		if (col.gameObject.tag == "Sichtbar") {
			//Debug.Log("Du siehst mich.");
			SMRenderer.enabled = true;

		} else /*if (col.gameObject.tag != "Sichtbar")*/{
			//Debug.Log ("Du siehst mich nicht mehr...");
			SMRenderer.enabled = false;
		
		}

	}
}
