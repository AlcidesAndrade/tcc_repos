using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SolvedPuzzle
{
    // Start is called before the first frame update
    public static bool isSolvedValue;

    public static void isSolved()
    {
        isSolvedValue = !isSolvedValue;
    }
}
