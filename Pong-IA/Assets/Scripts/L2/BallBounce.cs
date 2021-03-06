﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : L2SuperClass
{
    //3 vectors being used for calculating the cross-product.
    public GameObject A, B, C;

    private Vector3 normal;

    // Update is called once per frame
    void Update()
    {
        //performing the cross-product to find the normal of the plane of the paddle.
        Vector3 ba = A.transform.position - B.transform.position;
        Vector3 bc = C.transform.position - B.transform.position;
        normal = Vector3.Cross(ba, bc);
    }

    void OnTriggerEnter(Collider other) //Performs the collisions using cross-product calculated above.
    {
        if (other.tag.Equals("Ball"))
        {

            IncrementPoints();
            Rigidbody ball = other.GetComponent<Rigidbody>();

            //Initial velocity
            Vector3 uVel = ball.velocity;

            /* Debugging
			 * Debug.Log ("Initial vel: " + other.GetComponent<Rigidbody> ().velocity);
			 */

            //performing the reflection off of the paddle plane.
            ball.velocity = Vector3.Reflect(ball.velocity, normal);

            //resultant velocity
            Vector3 vVel = ball.velocity;

            //readjusting the velocity of the reflected ball to be the same as the resultant.
            ball.velocity = UnitVector(ball.velocity);
            xVel = ball.velocity.x;
            yVel = ball.velocity.y;

            /* Debugging
			 * Debug.Log ("End vel: " + other.GetComponent<Rigidbody> ().velocity);
			 * Debug.Log ("v Difference: " + (vVel - uVel));
			 * Debug.Log ("V Ratio: " + (vVel.magnitude / uVel.magnitude));
			 */
        }
    }

    private Vector3 UnitVector(Vector3 endVel)
    {
        float uMag = Vector3.Magnitude(unit);
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
            unit *= 1.15f;
            Debug.Log(unit);
            PaddleRotation *= 1.1f;
        }
    }
}
