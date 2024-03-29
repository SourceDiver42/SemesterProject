﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMind : MonoBehaviour
{
    public float moveSpeed;
    public float locateSpeed;
    public GameObject Radio;
    public GameObject Player;
    private GameObject Flare;
    private NavMeshAgent agent;
    private bool playerIsInRange;
    private bool radioIsInRange;
    private bool flareIsInRange;
    
    // Start is called before the first frame update
    void Start()
    {
        locateSpeed = moveSpeed / 1.5f;
        playerIsInRange = false;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = moveSpeed;
        Flare = GameObject.Find("Flare") ?? null;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Radio.activeSelf){
            agent.SetDestination(Radio.transform.position);
            if (radioIsInRange) Debug.Log("Radio is in range");
        }

        else if (flareIsInRange) {
            agent.SetDestination(Flare.transform.position);
            if (flareIsInRange) Debug.Log("Flare is in range");
        }

        else if (playerIsInRange){
            agent.SetDestination(Player.transform.position);
        }
        
        else if (!playerIsInRange) {
            SphereCollider sc = Player.GetComponent<SphereCollider>();
            Vector3 scpos = sc.ClosestPoint(this.transform.position);
            agent.SetDestination(scpos);
            agent.speed = locateSpeed;
        }
        
        
        //Could have made a class instead of messing with bools but what gives...


    }

    private void OnTriggerEnter(Collider other)
    {
        string switchVar = other.tag;

        switch (switchVar) {
            case "Player":
                Debug.Log("Player is in Range of " + name);
                playerIsInRange = true;
                break;
            case "Radio": //Yes I could have worked with audiolistener and audiosource TODO: MOVE RADIO AND FLARE TO SEPARATE CLASSES
                Debug.Log("Radio is in the area of " + name);
                radioIsInRange = true;
                break;
            case "Flare":
                Debug.Log("Flare capsule is in the area of " + name);
                flareIsInRange = true;
                break;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){
            Debug.Log("Player left range of " + name);
            playerIsInRange = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")){
            Debug.Log("Player is still in Range of " + name);
            playerIsInRange = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Player")){
            Debug.Log("Player was killed by " + name); //Oh my god! They killed Kenny!
            playerIsInRange = false; //obviously
        }
    }
}
