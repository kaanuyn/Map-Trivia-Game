using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zormarmaracevap : MonoBehaviour
{
    public bool isCorrect = false;
    public marmarazor marmarazor;

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
            marmarazor.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
           marmarazor.wrong();
        }
    }

}
