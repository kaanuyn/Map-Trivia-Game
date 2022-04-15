using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;
    public GameObject Secimpanel;


    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        Secimpanel.SetActive(true);
        //Quizpanel.SetActive(true);
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);

    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text =  score + "/" + totalQuestions;
    }

    public void correct()
    {
        //when you are right
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        //when you answer wrong
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
    }


}
