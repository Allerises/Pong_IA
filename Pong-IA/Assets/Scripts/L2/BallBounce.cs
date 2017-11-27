using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : L2SuperClass {
    public GameObject A, B, C; //3 vectors being used for calculating the cross-product
    Vector3 normal;
    bool bounced = false;

    // Update is called once per frame
    void Update ()
    {
        //performing the cross-product to find the normal of the plane of the paddle.
        Vector3 ba = A.transform.position - B.transform.position;
        Vector3 bc = C.transform.position - B.transform.position;
        normal = Vector3.Cross(ba, bc);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Ball") && !bounced)
        {
            bounced = true;
            Debug.Log("Entering\n"+normal+"\n"+other.GetComponent<Rigidbody>().velocity);
            other.GetComponent<Rigidbody>().velocity = Vector3.Reflect(other.GetComponent<Rigidbody>().velocity, normal);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        bounced = false;
    }
}
