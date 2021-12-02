using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    private List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public GameObject player;

    public Text QuestionText;
    public Text ScoreTxt;

    public GameObject QuizPanel;
    //public GameObject GameOverPanel;

    int totalQuestions = 0;
    public int score;

    private void Update(){
        if(QuizPanel.activeSelf){
            player = GameObject.Find("Player");
            player.transform.GetChild(0).gameObject.GetComponent<SpaceShipController>().isBlocked = true;
        }
    }

    private void Start()
    {
        player = GameObject.Find("Player");
        string currentPlanet = player.transform.GetChild(0).gameObject.GetComponent<SpaceShipController>().currentPlanet;
        QnA = CarregarPerguntas.GetQuestionsAndAnswers().Where(question => question.Planet == currentPlanet).ToList();
        totalQuestions = QnA.Count;
        generateQuestion();

    }

    void GameOver()
    {
        player = GameObject.Find("Player");

        GameObject spaceship = player.transform.GetChild(0).gameObject;
        SpaceShipController spaceshipController = spaceship.GetComponent<SpaceShipController>();

        spaceshipController.isBlocked = false;

        #region WORK AROUND MUDAR DPS TMJ
            spaceshipController.currentPlanet = "";
            spaceship.transform.position = new Vector3(spaceship.transform.position.x, spaceship.transform.position.y, 1884);
            GameObject.Find("Canva_Urano").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        #endregion

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

            if(QnA[currentQuestion].CorrectAnswer == i)
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