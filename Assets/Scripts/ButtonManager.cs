using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void ShowAnswer() {
        // Deleting button

        // Show answer canvas
        QnACanvasBehaviour.speechBubble.enabled = true;

        QnACanvasBehaviour.answerTMP.text = QnACanvasBehaviour.GetAnswer();

        Destroy(gameObject);

    }
}
