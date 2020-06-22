using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "npc1")
    //    {
    //        TriggerDialogue(); // press F to pickup

    //    }
    //}

    DialogueManager dialogueManager;

    private void Start()
    {
        dialogueManager = DialogueManager.Instance;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (dialogueManager.startedDialogue)
                dialogueManager.DisplayNextSentence();
            else
                dialogueManager.StartDialogue(dialogue);


        }
    }

}