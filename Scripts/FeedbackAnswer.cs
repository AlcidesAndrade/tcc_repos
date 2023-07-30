using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackAnswer : MonoBehaviour
{
    public Collider2D coll;
    public GameObject textFeedback;
    private IEnumerator Countdown()
    {
        int count = 3;

        while (count > 0)
        {
            yield return new WaitForSeconds(1f);
            count--;
        }

        textFeedback.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Colidiu");
        textFeedback.gameObject.SetActive(true);
        StartCoroutine(Countdown());
    }
}
