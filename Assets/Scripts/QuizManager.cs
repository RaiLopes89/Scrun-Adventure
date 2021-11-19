using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;
    public Text ScoreTxt;

    public GameObject QuizPanel;
    //public GameObject GameOverPanel;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        totalQuestions = QnA.Count;
        generateQuestion();
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        ScoreTxt.text = "Acertos: " +  score + " / " + totalQuestions;
        Debug.Log("Total: " + score);
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;


            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }

    }
}
