using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	// Properties
	public float StandingThreshold;


	#region Methods

	public bool IsStanding() {

		var isStanding = false;

		var xTilt = Mathf.Abs(transform.eulerAngles.x);
		var zTilt = Mathf.Abs(transform.eulerAngles.z);

		if (xTilt < StandingThreshold && zTilt < StandingThreshold) {
			isStanding = true;
		}

		return isStanding;
	}

	#endregion
}
