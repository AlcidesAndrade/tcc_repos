using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SolvedPuzzle
{
    // Start is called before the first frame update
    public static bool isSolvedValue;
    public static bool isBankPuzzleAnswered;

    public static void isSolved()
    {
        isSolvedValue = true;
    }

    public static void isntSolved() 
    {
        isSolvedValue = false;
    }
}
