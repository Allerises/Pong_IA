using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBall : L1SuperClass {

	public Text resume;

	void Awake(){
		resume.GetComponent<Text>();
	}

	void OnTriggerEnter(Collider other){
			other.transform.position = new Vector3 (0, 0, 0);
			other.attachedRigidbody.velocity = Vector3.zero;
			resume.enabled = true;
	}
}
