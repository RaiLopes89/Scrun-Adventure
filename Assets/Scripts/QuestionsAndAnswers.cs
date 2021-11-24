[System.Serializable]

public class QuestionsAndAnswers
{
    public int id {get; set;}
    public string Planet {get; set;}
    public string Question {get; set;}
    public string[] Answers {get; set;}
    public int CorrectAnswer {get; set;} = 0;
}
