using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public DialogueManager dm;
    public GameObject StartButton;

    public void OnTriggerEnter2D(Collider2D other)
    {
        StartButton.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        StartButton.SetActive(false);
        dm.EndDialogue();
    }
}
