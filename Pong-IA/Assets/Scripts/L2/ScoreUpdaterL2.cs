﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
using UnityEngine.UI;

public class ScoreUpdaterL2 : L2SuperClass
{

    private Text textObject;

    void Awake()
    {
        textObject = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tag.Equals("Speed"))
        {

            double diff = (points / 5 + 1);
            textObject.text = "Speed: " + diff;
        }
        else if (tag.Equals("Score"))
        {
            textObject.text = "Score: " + points;
        }
    }
}