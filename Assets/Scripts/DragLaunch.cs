﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(BowlingBall))]
public class DragLaunch : MonoBehaviour {

	// Variables
	BowlingBall _ball;
	Vector3 _initialPosition;
	float _initialTime;


	// Use this for initialization
	void Start () {
		_ball = gameObject.GetComponent<BowlingBall>();
	}

	public void DragStart() {
		_initialPosition = Input.mousePosition;
		_initialTime = Time.time;
	}

	public void DragEnd() {
		var currentPosition = Input.mousePosition;
		var currentTime = Time.time;
		var duration = currentTime - _initialTime;

		var speedX = (currentPosition.x - _initialPosition.x)/duration;
		var speedZ = (currentPosition.y - _initialPosition.y)/duration;

		var velocity = new Vector3(speedX, 0, speedZ);

		_ball.Launch(velocity);
	}
}
