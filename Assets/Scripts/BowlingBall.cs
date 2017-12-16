using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour {

	// Variables
	private Rigidbody _rigidBody;
	private AudioSource _audioSource;

	private bool _isLaunched = false;

	// Use this for initialization

	#region Lifecycle

	void Start () {
		_rigidBody = gameObject.GetComponent<Rigidbody>();
		_audioSource = gameObject.GetComponent<AudioSource>();

		_rigidBody.useGravity = false;
	}

	#endregion

	#region Public Methods

	public void Launch (Vector3 velocity)
	{
		_rigidBody.useGravity = true;

		_rigidBody.velocity = velocity;
		_audioSource.Play ();
		_isLaunched = true;
	}

	public void MoveStart(float x) 
	{
		if (_isLaunched)
			return;

		var newX = _rigidBody.position.x + x;
		var position = new Vector3(newX, _rigidBody.position.y, _rigidBody.position.z);

		_rigidBody.position = position;
	}

	#endregion
}
