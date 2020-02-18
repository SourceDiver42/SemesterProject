using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Actions")]
    public GameObject Activate;
    public GameObject Deactivate;

    
    
    [Header("Properties")]
    public bool Invert = false;
    public bool Broken = false;

    //public Animation anim;

    void Start()
    {
        Activate.SetActive(false);
        Deactivate.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Entity" || other.collider.tag=="Player"){
            Button_Lowering();
            //anim.Play();
        }
    }

    void Button_Lowering(){
        if(!Invert) {
            Activate.SetActive(true);
            Deactivate.SetActive(false);
        } else {
            Activate.SetActive(false);
            Deactivate.SetActive(true);
        }

    }

    void Button_Raising() {
         if(!Invert) {
            Activate.SetActive(false);
            Deactivate.SetActive(true);
        } else {
            Activate.SetActive(true);
            Deactivate.SetActive(false);
        }
    }
}
