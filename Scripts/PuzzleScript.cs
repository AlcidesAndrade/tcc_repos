using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    public GameObject puzzleBanco;
    public GameObject confirmAnswerPanelBanco; 
    public Text answerBanco;
    private void confirmAnswer(string confirmText)
    {
        confirmAnswerPanelBanco.SetActive(true);
        answerBanco.text = $"Sua resposta escolhida foi {confirmText}. Você tem certeza da resposta?";
    }
    public void rightAnswer(string confirmText)
    {
        SolvedPuzzle.isSolved();
        confirmAnswer(confirmText);
        puzzleBanco.gameObject.SetActive(false);
    }

    public void wrongAnswer(string confirmText)
    {
        SolvedPuzzle.isntSolved();
        confirmAnswer(confirmText);
        puzzleBanco.gameObject.SetActive(false);
    }

}
