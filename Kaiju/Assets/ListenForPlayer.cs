using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForPlayer : MonoBehaviour
{
   bool playerNearby = false;

    // Update is called once per frame
    void Update()
    {
        if(playerNearby && Input.GetMouseButtonDown(0)){
            DialogueTrigger trig = this.GetComponent<DialogueTrigger>();
            if(trig.dialoguePlaying){
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }else{
                trig.TriggerDialogue();
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
            playerNearby = true;
        }   
    }
}
