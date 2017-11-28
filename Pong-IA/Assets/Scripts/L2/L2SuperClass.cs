using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2SuperClass : MonoBehaviour {

	//In case I need the rotation of the paddle for any calculations
	public static Vector3 PaddleRotation = Vector3.zero;

	//Preset velocity for the ball allows for hardcoded computations.
	public static float xVel = 2f, yVel = 2f;

	//Unit vector for the ball's velocity at the start.
	private static Vector3 unit = new Vector3 (xVel, yVel, Vector3.zero);

	//Magnitude of the unit vector.
	public static float uMag = Vector3.Magnitude (unit);

	void Start(){
		QualitySettings.antiAliasing = 1;
	}
}
