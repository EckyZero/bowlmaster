using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Properties
	public BowlingBall ball; 
	public float stopAtZ;

	// Variables
	private Vector3 _offset;

	// Use this for initialization
	void Start () {
		_offset = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (ball.transform.position.z <= stopAtZ) {
			transform.position = ball.transform.position + _offset;
		}
	}
}
