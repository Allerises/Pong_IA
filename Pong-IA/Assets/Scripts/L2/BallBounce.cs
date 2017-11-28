using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : L2SuperClass {
    public GameObject A, B, C; //3 vectors being used for calculating the cross-product
    Vector3 normal;

    // Update is called once per frame
    void Update ()
    {
        //performing the cross-product to find the normal of the plane of the paddle.
        Vector3 ba = A.transform.position - B.transform.position;
        Vector3 bc = C.transform.position - B.transform.position;
		normal = Vector3.Cross (ba, bc);
	}

	private void OnTriggerEnter (Collider other) //Performs the collisions using the cross-product calculated above.
    {
		if (other.tag.Equals ("Ball"))
        {
			Vector3 uVel = other.GetComponent<Rigidbody> ().velocity;
			Debug.Log ("Initial vel: " + other.GetComponent<Rigidbody> ().velocity);

			other.GetComponent<Rigidbody> ().velocity = Vector3.Reflect (other.GetComponent<Rigidbody> ().velocity, normal);
			Vector3 vVel = other.GetComponent<Rigidbody> ().velocity;
			other.GetComponent<Rigidbody> ().velocity = UnitVector (other.GetComponent<Rigidbody> ().velocity);

			Debug.Log ("End vel: " + other.GetComponent<Rigidbody> ().velocity);
			Debug.Log ("v Difference: " + (vVel - uVel));
			Debug.Log ("V Ratio: " + (vVel.magnitude / uVel.magnitude));
        }
    }

	private Vector3 UnitVector (Vector3 endVel)
	{
		float endVelUnit = endVel.magnitude / uMag;
		Vector3 ret = endVel / endVelUnit;
		Debug.Log (uMag);
		Debug.Log (ret.magnitude);
		return ret;
	}
}
