using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HackTimer : MonoBehaviour {


	public Scrollbar HackTimeBar;



	// Use this for initialization
	void Start () {


		HackTimeBar.size = 0f;





		
	}
	
	// Update is called once per frame
	void Update () {
		HackTimeBar.size = HackTimeBar.size + 1f * Time.deltaTime * 0.01f;

		
	}
}
