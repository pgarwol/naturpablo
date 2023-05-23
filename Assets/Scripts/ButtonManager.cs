using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class ButtonManager : MonoBehaviour {
    // <<< MENU >>>
    public void Play() {
        // TODO: switch to game scene
    }

    public void ShowAuthors() {

    }

    public void QuitGame() {
        Application.Quit();
    }

    public void ShowAnswer() {
        // Deleting button
        Destroy(gameObject);

        // Show answer canvas
        QnACanvasBehaviour.speechBubble.enabled = true;

        QnACanvasBehaviour.answerTMP.text = QnACanvasBehaviour.GetAnswer();
    }
}