using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePaddle : MonoBehaviour {

	private Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody> ();
		QualitySettings.antiAliasing = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rb.transform.RotateAround (Vector3.zero, Vector3.forward, 1.5f);
		}else if(Input.GetKey(KeyCode.RightArrow)){
			rb.transform.RotateAround (Vector3.zero, Vector3.forward, -1.5f);
		}
	}
}
