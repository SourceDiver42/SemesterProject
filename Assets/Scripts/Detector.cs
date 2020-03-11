using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Detector : MonoBehaviour
{
    public Text text;
    public Text Announcer;
    public GameObject[] Collectibles;
    // Start is called before the first frame update
    void Start()
    {
        Announcer = GameObject.Find("Announcer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            if (text.text.Equals("7/7")){
                Announcer.enabled = true;
                Announcer.text = "Congratulations, you finished the game";
                Invoke("DisableText", 10);
                Invoke("Quit", 11);
            } else {
                Announcer.enabled = true;
                Announcer.text = "You need to keep looking";
                Invoke("DisableText", 5);
            }
        }
    }

    void DisableText() {
        Announcer.enabled = false;
    }

    void Quit() {
        Application.Quit();
    }
}
