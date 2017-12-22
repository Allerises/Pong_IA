using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBallL2 : L2SuperClass
{

    private Rigidbody ball;
    private bool atStart = true;
    public Text start;
    public Text resume;
    public Text indicator;

    void Awake()
    {
        ball = GetComponent<Rigidbody>();
        Time.timeScale = 0;
        //start.GetComponent<Text>();
        //resume.GetComponent<Text>();
        //indicator.GetComponent<Text>();
        resume.enabled = false;
    }

    //Start the game
    void StartGame()
    {
        if (atStart && !running)
        {
            ball.velocity = unit;
            running = true;
            atStart = false;
            Time.timeScale = 1;
            start.enabled = false;
            indicator.enabled = false;
            canMove = true;
        }
    }

    //Restart the game
    public void ResetGame()
    {
        if (points < 50 && lives > 0)
        {
            if (!atStart && !running && Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Resetting");
                ball.velocity = new Vector3(xVel, yVel, 0);
                running = true;
                resume.enabled = false;
            }
        }
        else if(lives == 0)
        {
            SceneManager.LoadScene("LostScene");
        }
        else
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    //Maintains state of game
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && atStart)
        {
            StartGame();
        }
        ResetGame();
    }
}
