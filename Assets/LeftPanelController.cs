using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class LeftPanelController : MonoBehaviour {

	public PinManager PinManager;
	public Text StandingPinCountText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var countStanding = PinManager.Pins.Count(p => p.IsStanding());

		StandingPinCountText.text = countStanding.ToString();
	}
}
