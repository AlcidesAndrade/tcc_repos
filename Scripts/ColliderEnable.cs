using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnable : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D coll;
    bool isSolved = false;
    private void Start()
    {
        coll = this.GetComponent<Collider2D>();
        coll.enabled = false;
    }

    // Update is called once per frame
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
}
