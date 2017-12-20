using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : L2SuperClass
{
    //3 vectors being used for calculating the cross-product.
	public GameObject A, B, C;
	
	Vector3 normal;

	// Update is called once per frame
	void Update ()
	{
		//performing the cross-product to find the normal of the plane of the paddle.
		Vector3 ba = A.transform.position - B.transform.position;
		Vector3 bc = C.transform.position - B.transform.position;
		normal = Vector3.Cross (ba, bc);
	}

	private void OnTriggerEnter (Collider other) //Performs the collisions using cross-product calculated above.
	{
		if (other.tag.Equals ("Ball")) {

            IncrementPoints();

			//Initial velocity
			Vector3 uVel = other.GetComponent<Rigidbody> ().velocity;

			/* Debugging
			 * Debug.Log ("Initial vel: " + other.GetComponent<Rigidbody> ().velocity);
			 */

			//performing the reflection off of the paddle plane.
			other.GetComponent<Rigidbody> ().velocity = Vector3.Reflect (other.GetComponent<Rigidbody> ().velocity, normal);

			//resultant velocity
			Vector3 vVel = other.GetComponent<Rigidbody> ().velocity;

			//readjusting the velocity of the reflected ball to be the same as the resultant.
			other.GetComponent<Rigidbody> ().velocity = UnitVector (other.GetComponent<Rigidbody> ().velocity);

			/* Debugging
			 * Debug.Log ("End vel: " + other.GetComponent<Rigidbody> ().velocity);
			 * Debug.Log ("v Difference: " + (vVel - uVel));
			 * Debug.Log ("V Ratio: " + (vVel.magnitude / uVel.magnitude));
			 */
		}
	}

	private Vector3 UnitVector (Vector3 endVel)
	{
		float endVelUnit = endVel.magnitude / uMag;
		Vector3 ret = endVel / endVelUnit;

		/* Debugging
		 * Debug.Log ("Unit vector magnitude: " + uMag);
		 * Debug.Log ("Ball Magnitude: " + ret.magnitude);
		 */

		return ret;
	}

    //Increments points
    void IncrementPoints()
    {
        points++;
        if (points % 5 == 0)
        {
            xVel *= 1.3f;
            yVel *= 1.3f;
            Debug.Log(xVel + ", " + yVel);
            PaddleRotation += 0.1f;
        }
    }
}
