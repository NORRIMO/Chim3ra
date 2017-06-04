using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideoWithAlphaShader : MonoBehaviour {

	void Start () {
		MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		movie.loop = true;
		//GetComponent<AudioSource>().clip = movie.audioClip;
		//GetComponent<AudioSource>().Play ();
		movie.Play ();
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
