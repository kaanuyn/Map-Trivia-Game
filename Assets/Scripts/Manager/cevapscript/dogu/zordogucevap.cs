﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zordogucevap : MonoBehaviour
{
    public bool isCorrect = false;
    public doguzor doguzor;

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
            doguzor.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            doguzor.wrong();
        }
    }

}
