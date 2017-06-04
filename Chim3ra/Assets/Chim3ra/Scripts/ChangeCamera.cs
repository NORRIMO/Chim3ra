using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

	public Camera[] cams;

	public void CameraOne(){
		cams [0].enabled = true;
		cams [1].enabled = false;
		cams [2].enabled = false;



	}

	public void CameraTwo(){
		cams [0].enabled = false;
		cams [1].enabled = true;
		cams [2].enabled = false;



	}

	public void CameraThree(){
		cams [0].enabled = false;
		cams [1].enabled = false;
		cams [2].enabled = true;



	}
		

		
}
