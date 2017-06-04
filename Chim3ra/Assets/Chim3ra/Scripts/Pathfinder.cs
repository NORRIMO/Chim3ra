using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour {

	//public Transform[] destinationPoint;
	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	public int currentPoint = 0;



	// Use this for initialization
	void Start () {
		//transform.GetComponent<UnityEngine.AI.NavMeshAgent> ().destination = destinationPoint.position;


	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 dir = path [currentPoint].position - transform.position;

		//transform.position += dir * Time.deltaTime * speed;
		
	}

	void OnDrawGizmos () {
	
		if(path.Length > 0)
		for (int i = 0; i < path.Length; i++) {
			if (path [i] != null) {
				Gizmos.DrawSphere (path [i].position, reachDist);

			}
		}

	}
}
