using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class CarregarPerguntas

{
    public static List<QuestionsAndAnswers> GetQuestionsAndAnswers()
    {
        List<QuestionsAndAnswers> normalizedQuestions = new List<QuestionsAndAnswers>();

        TextAsset rawTextContent = Resources.Load<TextAsset>("Perguntas_csv/perguntas");
        string[] data = rawTextContent.text.Split(new char[] { '\n' });

        for (int i = 1; i <= data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            if (row[1] != "")
            {
                QuestionsAndAnswers qnA = new QuestionsAndAnswers();

                int currentQuestionId;
                int.TryParse(row[0], out currentQuestionId);

                qnA.id = currentQuestionId;
                qnA.Planet = row[1];
                qnA.Question = row[2];
                
                int correctAnswer = -1;
                int.TryParse(row[7], out correctAnswer);
                qnA.CorrectAnswer = correctAnswer;
                
                string[] answers = new string[4];
                for(var x = 3; x<=6;x++){
                    answers[x-3] = row[x];
                }

                qnA.Answers = answers;

                normalizedQuestions.Add(qnA);
            }
        }

        return normalizedQuestions;
    }
}
