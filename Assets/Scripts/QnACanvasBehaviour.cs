using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class QnACanvasBehaviour : MonoBehaviour {

    public QuestionsSO qSO;
    public static string question;
    public static string answer;

    public static TextMeshProUGUI questionTMP;
    public static TextMeshProUGUI answerTMP;

    public static Canvas speechBubble;

    public string folderName = "DataBase/Questions";
    QuestionsSO[] questions;

    private void Awake() {
        LoadQuestions();
    }

    private void LoadQuestions() {
        questions = Resources.LoadAll<QuestionsSO>(folderName);
    }

    void Start() {
        //qSO = TriggerQnACanvas.GetQuestions()[0];
        qSO = questions[Random.Range(0, questions.Length)];

        questionTMP = GameObject.Find("QuestionTMP").GetComponent<TextMeshProUGUI>();
        answerTMP = GameObject.Find("AnswerTMP").GetComponent<TextMeshProUGUI>();

        speechBubble = GameObject.Find("SpeechBubbleCanvas").GetComponent<Canvas>();
        speechBubble.enabled = false;

        question = qSO.question;
        answer = qSO.answer;
        // qSO.img;

        questionTMP.text = question;
    }

    public static string GetAnswer() {
        return answer;
    }

}
