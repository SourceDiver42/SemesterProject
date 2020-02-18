using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterBehaviour : MonoBehaviour
{

    public GameObject Player;
    public GameObject DestinationTeleporter;
    private Transform destinationCoords;
    // Start is called before the first frame update
    void Start()
    {
        destinationCoords = DestinationTeleporter.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision other) {
        if (other.Equals) {
            Player.transform.position = destinationCoords.position;
        }
    }*/
}
