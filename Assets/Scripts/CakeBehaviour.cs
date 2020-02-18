using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeBehaviour : MonoBehaviour
{
    public GameObject Cake;
    public Text TheCakeIsALie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.tag =="Player") {
            Cake.SetActive(false);
            TheCakeIsALie.enabled = true;
            Invoke("DisableText", 2f);      //Method Invoke https://stackoverflow.com/a/32322522
        }
    }
    void DisableText() {
        TheCakeIsALie.enabled = false;
    }


    
    
}
