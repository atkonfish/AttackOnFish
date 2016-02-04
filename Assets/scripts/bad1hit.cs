﻿using UnityEngine;
using System.Collections;
 



public class bad1hit : MonoBehaviour {
   public int hp = 2;
   public int hitScore = 50;
   // public GameObject enemy;


    private int enemy = 0;

	void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "playerbullet")

        {
            hp--;
            scoreCounter.score += hitScore;
        }

        if (coll.gameObject.tag == "player")
        {
            hp = hp - 4;
        }
  
        if (hp <= 0)
        {
            Destroy(gameObject);
            enemy++;
        }
    }
}

