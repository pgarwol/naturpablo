using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine;

public class TestingScript : MonoBehaviour {
    
    public QuestionsData questionsData;
    private static TextMeshProUGUI questionTMP;
    private static TextMeshProUGUI answerTMP;

    private static string question;
    private static string answer;

    private void Start() {
        question = questionsData.question;
        answer = questionsData.answer;
        
        questionTMP = GameObject.Find("Question").GetComponent<TextMeshProUGUI>();
        answerTMP = GameObject.Find("Answer").GetComponent<TextMeshProUGUI>();

        questionTMP.text = question;
        answerTMP.text = answer;
    }
}
