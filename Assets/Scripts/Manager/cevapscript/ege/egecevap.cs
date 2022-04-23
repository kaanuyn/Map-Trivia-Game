using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class egecevap : MonoBehaviour
{
    public bool isCorrect = false;
    public ege ege;

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
            ege.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            ege.wrong();
        }
    }

}
