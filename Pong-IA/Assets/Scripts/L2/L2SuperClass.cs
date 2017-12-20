using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2SuperClass : MonoBehaviour
{

    //Paddle Rotation
    public static float PaddleRotation = 1f;

    //Preset velocity for the ball
    public static float xVel = 2.5f, yVel = 2.5f;

    //Unit velocity vector of the ball
    public static Vector3 unit = new Vector3(xVel, yVel, 0f);

    //Magnitude of the unit vector.
    public static float uMag = Vector3.Magnitude(unit);

    //Game control vars
    public static int points = 0;
    public static bool running = false;

    private void Awake()
    {
        PaddleRotation = 1f;
        xVel = 2.5f;
        yVel = 2.5f;
        unit = new Vector3(xVel, yVel, 0f);
        uMag = Vector3.Magnitude(unit);
        points = 0;
        running = false;
    }
}