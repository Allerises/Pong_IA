using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices.ComTypes;

public class CompController : L1SuperClass {

	private Rigidbody rb;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (running) {
			rb.transform.position = new Vector3 (rb.transform.position.x, 
				Mathf.Clamp (rb.transform.position.y, -3.8f, 3.8f), 
				rb.transform.position.z);
				rb.velocity = new Vector3 (0, yVel, 0);
		} else {
			rb.transform.position = new Vector3 (rb.transform.position.x, 0, 0);
			rb.velocity = Vector3.zero;
		}
	}
}
