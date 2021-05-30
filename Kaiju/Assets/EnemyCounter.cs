using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    public static int numEnemies;
    // Start is called before the first frame update
    void Start()
    {
        numEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log("Enemy Died" + "  " + numEnemies);
    }

    // Update is called once per frame
    void Update()
    {
        if(numEnemies <= 0){
            FindObjectOfType<LevelLoader>().LoadCredits();
        }
    }
}
