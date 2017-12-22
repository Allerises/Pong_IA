using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    public Canvas MainMenu, LevelSelect;

    public void Start()
    {
        MainMenu.GetComponent<Canvas>();
        LevelSelect.GetComponent<Canvas>();
        LevelSelect.enabled = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackButton();
        }
    }

    public void PlayButton()
    {
        MainMenu.enabled = false;
        LevelSelect.enabled = true;
    }

    public void BackButton()
    {
        MainMenu.enabled = true;
        LevelSelect.enabled = false;
    }

    public void ControlsButton()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Loadl1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Loadl2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
