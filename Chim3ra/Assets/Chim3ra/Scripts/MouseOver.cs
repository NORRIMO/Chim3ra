using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour {

	public Texture2D Default;
	public Texture2D Look;
	public Texture2D Click;

	private Ray ray;

	public GameObject tvTarget;
	public GameObject pcTarget;
	public GameObject musicTarget;
	public GameObject thermostatTarget;
	public GameObject groundTarget;

	void SetCursorTexture(Texture2D texture) {
		Cursor.SetCursor (texture, Vector2.zero, CursorMode.Auto);
	
	}



	// Use this for initialization
	void Start () {
		
		SetCursorTexture (Default);
		tvTarget.SetActive (false);
		pcTarget.SetActive (false);
		musicTarget.SetActive (false);
		thermostatTarget.SetActive (false);
		groundTarget.SetActive (false);
	}


	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit;
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		//MouseOver
		if (Physics.Raycast (ray, out hit)) {

			if (hit.collider.gameObject.tag.Contains ("Event")) {
				//Debug.Log ("Look");
				SetCursorTexture (Look);
				if (Input.GetMouseButton (0)) {
					//Debug.Log ("Look");
					SetCursorTexture (Click);
					}
				} else {
					SetCursorTexture (Default);
				}
			}


		//zur Aktivierung der 
		if (Physics.Raycast (ray, out hit)) {

			if (hit.collider.gameObject.name.Contains ("TV_Event")) {
				if (Input.GetMouseButton (0)) {
					tvTarget.SetActive (true);
				}
			}

			if (hit.collider.gameObject.name.Contains ("PC_Event")) {
				if (Input.GetMouseButton (0)) {
					pcTarget.SetActive (true);
				}
			}

			if (hit.collider.gameObject.name.Contains ("Music_Event")) {
				if (Input.GetMouseButton (0)) {
					musicTarget.SetActive (true);
				}
			}

			if (hit.collider.gameObject.name.Contains ("Thermostat_Event")) {
				if (Input.GetMouseButton (0)) {
					thermostatTarget.SetActive (true);
				}
			}

			if (hit.collider.gameObject.name.Contains ("Feuermelder_Event")) {
				if (Input.GetMouseButton (0)) {
					groundTarget.SetActive (true);
				}
			}
		
		}
	}
}