using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex = 0;

    public string GetQuestion()
    {
        return question;
    }

    public string[] GetAnswers()
    {
        return answers;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string getAnswerAtIndex(int answerIndex)
    {
        if(answerIndex >= 0 && answerIndex <= 3)
        {
            return answers[answerIndex];
        }
        else
        {
            return "Index out of bounds";
        }
    }
}
