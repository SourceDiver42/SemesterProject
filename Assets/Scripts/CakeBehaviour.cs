using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeBehaviour : MonoBehaviour
{
    public Material opaqueMaterial;
    public GameObject Cake;
    public Text TheCakeIsALie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cake.GetComponent<Renderer>().material = opaqueMaterial;
    }

    void OnTriggerEnter(Collider other){
        if (other.tag =="Player") {
            TheCakeIsALie.text = "The Cake Is A Lie";
            TheCakeIsALie.enabled = true;
            Invoke("DisableText", 2f);      //Method Invoke https://stackoverflow.com/a/32322522
            Cake.SetActive(false);
            
        }
    }
    void DisableText() {
        TheCakeIsALie.enabled = false;
    }


    
    
}
