using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class LoopingHackWindow : MonoBehaviour {

	public float speed = 2f;
	Vector2 pos;
	public GameObject text2;
	public float targetPos;

	// Use this for initialization
	void Start () {

		pos = transform.localPosition;

	}
	
	// Update is called once per frame
	void Update () {



		pos.y -= 5f * Time.deltaTime * speed;
		transform.localPosition = pos;

		if (pos.y <= -542) {
			pos.y = 4f;
		}
	}
}
