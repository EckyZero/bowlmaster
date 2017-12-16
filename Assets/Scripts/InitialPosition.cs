using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BowlingBall))]
public class InitialPosition : MonoBehaviour {

	// Properties
	public float MinX;
	public float MaxX;

	// Variable
	BowlingBall _ball;
	float _initialDragX;
	float _initialBallX;
	public RangeInt range;

	// Use this for initialization
	void Start () 
	{
		_ball = gameObject.GetComponent<BowlingBall>();

		var rigidBody = gameObject.GetComponent<Rigidbody>();

		_initialBallX = rigidBody.position.x;
	}

	public void DragStart() 
	{
		_initialDragX = Input.mousePosition.x;
	}

	public void Drag()
	{
		var dragDiff = Input.mousePosition.x - _initialDragX;

		Move(dragDiff);
	}

	public void MoveRight() {
		Move(1);
	}

	public void MoveLeft() {
		Move(-1);
	}

	private void Move(float value) {

		var diffFromCurrentPosition = _initialDragX + value;
		var diffFromInitialPosition = _initialBallX - diffFromCurrentPosition;

		Debug.Log("========");
		Debug.Log("_initialDragX: " + _initialDragX);
		Debug.Log("_initialBallX: " + _initialBallX);
		Debug.Log("value: " + value);
		Debug.Log("diffFromCurrentPosition: " + diffFromCurrentPosition);
		Debug.Log("diffFromInitialPosition: " + diffFromInitialPosition);

		if (MinX <= diffFromInitialPosition && diffFromInitialPosition <= MaxX) {
			_ball.MoveStart(value);
			_initialDragX = diffFromCurrentPosition;
		}
	}
}
