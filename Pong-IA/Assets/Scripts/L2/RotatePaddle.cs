using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePaddle : L2SuperClass {

	private Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody> ();
		QualitySettings.antiAliasing = 1;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.transform.RotateAround(Vector3.zero, Vector3.forward, PaddleRotation);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.transform.RotateAround(Vector3.zero, Vector3.forward, -PaddleRotation);
            }
        }
	}
}
