using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2SuperClass : MonoBehaviour {

	//In case I need the rotation of the paddle for any calculations.
	public static Vector3 PaddleRotation = Vector3.zero;

	//Preset velocity for the ball.
	public static float xVel = 2.5f, yVel = 2.5f;

	//Unit vector for the ball's velocity at the start.
	public static Vector3 unit = new Vector3 (xVel, yVel, 0f);

	//Magnitude of the unit vector.
	public static float uMag = Vector3.Magnitude (unit);

    //Game control vars
    public static int points = 0;
    public static bool running = false;
}
