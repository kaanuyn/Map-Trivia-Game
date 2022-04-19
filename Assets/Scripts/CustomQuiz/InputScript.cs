using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InputScript : MonoBehaviour
{
    InputField iField;
    private string Question;
    public string[] Answers;
    public int CorrectAnswer;

    void MyFunction()
    {
        Question = iField.text;

    }
}