using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class QnACanvasBehaviour : MonoBehaviour {

    public QuestionsSO qSO;
    public static string question;
    public static string answer;

    // TMP Elements
    public static TextMeshProUGUI questionTMP;
    public static TextMeshProUGUI answerTMP;

    public static Canvas speechBubble;

    void Start() {
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
