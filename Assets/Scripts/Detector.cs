using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detector : MonoBehaviour
{
    public Text text;
    public GameObject[] Collectibles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            if (text.text.Contains("8")){
                //GAmefinishedstuff
            } else {
                //Youneedto keep looking
            }
        }
    }
}
