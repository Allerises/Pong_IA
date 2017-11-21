using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class PlayerController : L1SuperClass {
	private Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (running) {
			rb.transform.position = new Vector3 (-8.1f, 
				Mathf.Clamp (rb.transform.position.y, -3.8f, 3.8f), 
				rb.transform.position.z);
			
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				rb.velocity = new Vector3 (0, pyVel, 0);
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				rb.velocity = new Vector3 (0, -pyVel, 0);
			} else if (!Input.anyKey) {
				rb.velocity = Vector3.zero;
			}
		} else {
			rb.transform.position = new Vector3 (-8.1f, 0, 0);
			rb.velocity = Vector3.zero;
		}
	}
}
