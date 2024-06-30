using UnityEngine;
using UnityEngine.UI;


public enum OperationType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

public class QuestionManager : MonoBehaviour
{
    public Text questionText;
    public Button[] answerButtons;
    public OperationType operationType;
    private int correctAnswer;

    void Start()
    {
        GenerateQuestion();
    }

    void GenerateQuestion()
    {
        int number1 = Random.Range(1, 101);
        int number2 = Random.Range(1, 101);
        correctAnswer = number1 + number2;

        switch (operationType)
        {
            case OperationType.Addition:
                correctAnswer = number1 + number2;
                questionText.text = $"{number1} + {number2} = ";
                break;
            case OperationType.Subtraction:
                correctAnswer = number1 - number2;
                questionText.text = $"{number1} - {number2} = ";
                break;
            case OperationType.Multiplication:
                correctAnswer = number1 * number2;
                questionText.text = $"{number1} x {number2} = ";
                break;
            case OperationType.Division:
                correctAnswer = number1 / number2;
                questionText.text = $"{number1} / {number2} = ";
                break;
        }

        int correctAnswerIndex = Random.Range(0, answerButtons.Length);
        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (i == correctAnswerIndex)
            {
                answerButtons[i].GetComponentInChildren<Text>().text = correctAnswer.ToString();
                answerButtons[i].onClick.AddListener(() => OnAnswerSelected(correctAnswer));
            }
            else
            {
                int wrongAnswer;
                do
                {
                    wrongAnswer = Random.Range(1, 201); 
                } while (wrongAnswer == correctAnswer);
                answerButtons[i].GetComponentInChildren<Text>().text = wrongAnswer.ToString();
                answerButtons[i].onClick.AddListener(() => OnAnswerSelected(wrongAnswer));
            }
        }
    }

    void OnAnswerSelected(int selectedAnswer)
    {
        if (selectedAnswer == correctAnswer)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Incorrect!");
        }

        foreach (Button btn in answerButtons)
        {
            btn.onClick.RemoveAllListeners();
        }

        GenerateQuestion();
    }
}
