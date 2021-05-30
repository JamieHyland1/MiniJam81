using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    public DialogueTrigger currentTrigger;



    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue, DialogueTrigger trigger){
        currentTrigger = trigger;
        Debug.Log("");
        animator.SetBool("isOpen",true);
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

    }
    public void DisplayNextSentence(){
        if(sentences.Count == 0){
            endDialogue();
            return;
        }
        dialogueText.text = sentences.Dequeue();
    }

    private void endDialogue(){
        animator.SetBool("isOpen",false);
        nameText.text = "";
        dialogueText.text = "";
        currentTrigger.updateCheckList();
        currentTrigger.dialoguePlaying = false;
        currentTrigger = null;
        sentences.Clear();
    }
}
