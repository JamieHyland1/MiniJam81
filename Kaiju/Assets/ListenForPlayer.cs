using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForPlayer : MonoBehaviour
{
   bool playerNearby = false;
   public DialogueTrigger trigger;

    // Update is called once per frame
    void Update()
    {
        if(playerNearby && Input.GetMouseButtonDown(0)){
            if(trigger.dialoguePlaying){
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }else{
                trigger.TriggerDialogue();
            }
        }
    }


    private void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name =="Player"){
            playerNearby = true;
        }    
    }

    private void OnCollisionExit(Collision other) {
         if(other.gameObject.name =="Player"){
            playerNearby = false;
        }   
    }
}
