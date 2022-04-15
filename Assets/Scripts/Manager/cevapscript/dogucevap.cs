using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dogucevap : MonoBehaviour
{
    public bool isCorrect = false;
    public dogu dogu;

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
            dogu.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            dogu.wrong();
        }
    }

}
