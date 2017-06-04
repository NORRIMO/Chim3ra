using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCollider : MonoBehaviour {



	private Ray ray;

	// Use this for initialization
	void Start () {

		gameObject.SetActive (false);
		
		
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit)) {
			
			if (hit.collider.gameObject.name.Contains ("TV_Event")) {
				gameObject.SetActive (true);
				Debug.Log("collllllllllllllllllllllllll");
			}
		}
			
	}
}
