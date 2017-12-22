using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1SuperClass : MonoBehaviour
{

    //CPU paddle + ball velocity
    public static float xVel = 5f, yVel = 5f;

    //player paddle velocity
    public static float pyVel = 5f;

    //Ball position for calculations
    public static Vector3 ballPosition = new Vector3(0, 0, 0);

    //Game control vars
    public static int points = 0;
    public static bool running = false;
    public static int lives = 3;

    private void Start()
    {
        int i = Random.Range(0, 2);
        xVel = 5f;
        yVel = 5f;
        switch (i)
        {
            case 0:
                xVel *= -1;
                break;
            case 1:
                yVel *= -1;
                break;
            case 2:
                xVel *= -1;
                yVel *= -1;
                break;
        }
        pyVel = 5f;
        ballPosition = new Vector3(0, 0, 0);
        points = 0;
        running = false;
    }
}



