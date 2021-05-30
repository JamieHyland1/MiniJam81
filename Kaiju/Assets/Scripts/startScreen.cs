using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreen : MonoBehaviour
{
    public Animator animatorBox;
    public Animator animatorText;
    bool isOpen;
    // Start is called before the first frame update
    void Start(){
        animatorBox.SetBool("IsOpen",isOpen);
        animatorText.SetBool("IsOpen",isOpen);
    }

    // Update is called once per frame
    void Update(){
        animatorBox.SetBool("IsOpen",isOpen);
        animatorText.SetBool("IsOpen",isOpen);

        if(Input.GetKeyDown(KeyCode.Space)){
            isOpen = !isOpen;
        } 
        if(Input.GetKeyDown(KeyCode.Return)){
            FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>().LoadNextLevel();
        }
    }
}
