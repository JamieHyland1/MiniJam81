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

  public void updateCheckList(){
    CheckNPCs n = FindObjectOfType<CheckNPCs>().GetComponent<CheckNPCs>();
    if(this.gameObject.name == "Buddy1")n.Buddy1=true;
    if(this.gameObject.name == "Buddy2")n.Buddy2=true;
    if(this.gameObject.name == "Buddy3")n.Buddy3=true;
    if(this.gameObject.name == "Buddy4")n.Buddy4=true;
    
  }
}
