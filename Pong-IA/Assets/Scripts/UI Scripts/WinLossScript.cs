using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinLossScript : MonoBehaviour {

    public Canvas UI;

	// Use this for initialization
	void Start () {
        UI.GetComponent<Canvas>();
	}

    public void Loadl1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Loadl2()
    {
        SceneManager.LoadScene("Level2");
    }


    public void OnClickMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
