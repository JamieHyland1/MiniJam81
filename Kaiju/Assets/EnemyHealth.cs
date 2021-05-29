﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   [SerializeField]
   int enemyHealth = 100;


   public void takeDamage(int damage){
       enemyHealth -= damage;
       if(enemyHealth <= 0)Destroy(this.gameObject);

   }
}