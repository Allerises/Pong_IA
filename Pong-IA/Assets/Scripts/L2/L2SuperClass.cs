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

    //Game control vars
    public static int points = 0;
    public static bool running = false;
    public static bool canMove = false;
    public static int lives = 3;

    private void Start()
    {
        int i = Random.Range(0, 1);
        PaddleRotation = 1f;
        xVel = 2.5f;
        yVel = 2.5f;
        if (i == 0)
        {
            xVel *= -1;
        }
        unit = new Vector3(xVel, yVel, 0f);
        points = 0;
        running = false;
        canMove = false;
        lives = 3;
    }
}