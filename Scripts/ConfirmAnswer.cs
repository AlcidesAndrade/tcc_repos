using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmAnswer : MonoBehaviour
{
    public GameObject puzzleBanco;
    public GameObject confirmPanel;
    public GameObject rightAnswer;

    public void confirmAnswer()
    {
        puzzleBanco.gameObject.SetActive(false);
        confirmPanel.gameObject.SetActive(false);
        SolvedPuzzle.isBankPuzzleAnswered = true;
    }

    public void cancelAnswer()
    {
        SolvedPuzzle.isntSolved();
        puzzleBanco.gameObject.SetActive(true);
        Debug.Log("Resposta cancelada");
        confirmPanel.gameObject.SetActive(false);
    }
}
