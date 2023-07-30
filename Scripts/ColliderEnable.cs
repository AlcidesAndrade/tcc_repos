using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnable : MonoBehaviour
{
    public Collider2D coll;
    public GameObject puzzle;
    bool isSolved = false;
    private void Start()
    {
        // coll = this.GetComponent<Collider2D>();
        coll.enabled = false;
    }

    private void Update()
    {
        isSolved = SolvedPuzzle.isSolvedValue;
        if (isSolved)
        {
            coll.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            SolvedPuzzle.isSolved();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        //verifica se o puzzle já está na tela, caso não, exibe
        if(!puzzle.gameObject.activeSelf && !SolvedPuzzle.isBankPuzzleAnswered) 
        {
            Debug.Log("Ativando");
            puzzle.gameObject.SetActive(true);
        }
    }
}
