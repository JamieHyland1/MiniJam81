using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  public bool dialoguePlaying = false;
  public Dialogue dialogue;
  public void TriggerDialogue(){
    if(dialoguePlaying == false){
      dialoguePlaying = true;
      FindObjectOfType<DialogueManager>().StartDialogue(this.dialogue,this);
    }
  }
}
