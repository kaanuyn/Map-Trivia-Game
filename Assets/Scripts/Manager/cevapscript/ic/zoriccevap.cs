﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoriccevap : MonoBehaviour
{
    public bool isCorrect = false;
    public iczor ic;

    public Color startColor;

    private void Start()
    {
        startColor = Color.gray;
        
    }

    public void Answer()
    {
        if(isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            ic.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            ic.wrong();
        }
    }

}
