using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correction : MonoBehaviour
{

    public GameObject[] Buttons;
    private bool isCorrect;


    public Button selected;

    public void start()
    {
        selected = GameObject.FindGameObjectWithTag("selectionbuttons").GetComponent<Button>();
        selected.onClick.AddListener(() => Correct());

    }

    public void Correct()
    {

        isCorrect = true;
        
            selected.GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
        


    }
    public void False()
    {
        isCorrect = false;
        
            selected.GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
        
    }

}
