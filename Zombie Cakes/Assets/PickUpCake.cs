﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PickUpCake : MonoBehaviour { 

    public GameObject cakePrefab;
    public cakeMechanics thisCake;
    public int randomNumber;
    public int cakeCounter;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        // handles the event of the cake having been delivered
        if (GameObject.FindGameObjectWithTag("Cake") == null)
        {
            cakeCounter++;

            // after the player has dropped off 3 cakes > Player wins!
            if (cakeCounter == 4) {
                SceneManager.LoadScene(3);
            }


            // decide on store to spawn cake (random number between 1 and 3)
            randomNumber = Random.Range(1, 4);

            if (randomNumber == 1)
            {

                var i = Instantiate(cakePrefab, new Vector3(1040.34f, -83.50644f, 93.21001f), Quaternion.identity);
                thisCake = i.GetComponent<cakeMechanics>();

                thisCake.cakeHolder = GameObject.Find("LeftCakeHolder").GetComponent<Transform>();
                thisCake.cakeHealthBar = GameObject.Find("CakeBar").GetComponent<CakeHealthBar>();
                thisCake.playerAtt = GameObject.Find("RightPlayerArm").GetComponent<playerAttack>();
                thisCake.playerMove = GameObject.Find("Player").GetComponent<PlayerMovement>();

            } 
            else if (randomNumber == 2)
            {

                var i = Instantiate(cakePrefab, new Vector3(1238.81f, -83.64644f, 997.328f), Quaternion.identity);
                thisCake = i.GetComponent<cakeMechanics>();

                thisCake.cakeHolder = GameObject.Find("LeftCakeHolder").GetComponent<Transform>();
                thisCake.cakeHealthBar = GameObject.Find("CakeBar").GetComponent<CakeHealthBar>();
                thisCake.playerAtt = GameObject.Find("RightPlayerArm").GetComponent<playerAttack>();
                thisCake.playerMove = GameObject.Find("Player").GetComponent<PlayerMovement>();

            } 
            else
            if (randomNumber == 3){

                var i = Instantiate(cakePrefab, new Vector3(172.0261f, -83.64644f, 126.6947f), Quaternion.identity);
                thisCake = i.GetComponent<cakeMechanics>();

                thisCake.cakeHolder = GameObject.Find("LeftCakeHolder").GetComponent<Transform>();
                thisCake.cakeHealthBar = GameObject.Find("CakeBar").GetComponent<CakeHealthBar>();
                thisCake.playerAtt = GameObject.Find("RightPlayerArm").GetComponent<playerAttack>();
                thisCake.playerMove = GameObject.Find("Player").GetComponent<PlayerMovement>();

            }
            
        }
    }
}
