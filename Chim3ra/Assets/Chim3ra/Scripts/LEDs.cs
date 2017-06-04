using System.Collections;
using UnityEngine;

public class LEDs : MonoBehaviour {

	public Light light;

	void Start (){
		light = GetComponent<Light> ();
		light.intensity = 0f;
	}
}