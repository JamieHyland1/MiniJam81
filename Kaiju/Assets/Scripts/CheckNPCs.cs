using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNPCs : MonoBehaviour
{
   public bool Buddy1 = false;
   public bool Buddy2 = false;
   public bool Buddy3 = false;
   public bool Buddy4 = false;

   bool boostedStats = false;

    private void Update() {
        if((((Buddy1&&Buddy2)&&Buddy3))&&Buddy4){
           if(!boostedStats)boostStats();
            FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>().LoadLastLevel();
        }
    }

    void boostStats(){
         PlayerVariables.playerHealth += 20;
            PlayerVariables.speed += 20;
            PlayerVariables.damage += 15;
            PlayerVariables.rayCastDistance += 5;
            boostedStats = true;
    }
}
