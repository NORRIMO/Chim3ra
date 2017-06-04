using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class DragingScript : MonoBehaviour {

	private float distance = 2; 
	public Camera cam;

	/*
	// Use this for initialization
	void Start () {


		
	}
	*/

	void OnMouseDrag() {
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = cam.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	
	}
/*
	// Update is called once per frame
	void Update () {
		

	}*/
}
