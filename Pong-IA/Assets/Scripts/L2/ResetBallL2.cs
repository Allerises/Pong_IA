using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBallL2 : L2SuperClass {

    public Text resume;

    void Awake()
    {
        resume.GetComponent<Text>();
    }

    void OnTriggerExit(Collider other)
    {
        xVel = other.attachedRigidbody.velocity.x;
        yVel = other.attachedRigidbody.velocity.y;
        other.transform.position = new Vector3(0, 0, 0);
        other.attachedRigidbody.velocity = Vector3.zero;
        resume.enabled = true;
        running = false;
        lives--;
    }
}
