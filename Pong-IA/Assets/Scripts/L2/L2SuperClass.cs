using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2SuperClass : MonoBehaviour {

	public static Vector3 PaddleRotation = Vector3.zero;
	public static float xVel = 2, yVel = 2;

	void Start(){
		QualitySettings.antiAliasing = 1;
	}
}
