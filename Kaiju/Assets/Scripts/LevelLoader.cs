using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public static float transitionTime = 1f;
    // Update is called once per frame
   




    public void LoadNextLevel(){
        Debug.Log("Loading");
       StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }

    public void LoadLastLevel(){
        Debug.Log("Loading");
       StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex-1));
    }

    public void LoadCredits(){
        Debug.Log("Loading");
       StartCoroutine(loadLevel(3));
    }


    public IEnumerator loadLevel(int levelIndex){
        yield return new WaitForSeconds(2f);
            transition.SetTrigger("Play");
            yield return new WaitForSeconds(transitionTime);
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(levelIndex);
    }

}
