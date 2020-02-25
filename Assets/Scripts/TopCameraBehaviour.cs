using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopCameraBehaviour : MonoBehaviour
{
    //private GameObject HitObject;
    //private Color HitObjectRendererColor;
    
    public Material transparentMaterial;
    public Material opaqueMaterial;
    GameObject previousHit;
    private Camera topCamera;
    
    void Start()
    {
        previousHit = GameObject.Find("previousHit");
        topCamera = GetComponent<Camera>();
        topCamera.enabled = false;
        
    }


    void FixedUpdate()
    {
        Vector3 playerPos = GameObject.FindWithTag("Player").transform.position;
        Vector3 direction = ( playerPos - transform.position );
        Ray ray = new Ray(transform.position, direction);
        RaycastHit hit;
        GameObject HitObject;
          
        
        if (topCamera.isActiveAndEnabled){
            if (Physics.Raycast(ray, out hit)){

                Debug.DrawRay (transform.position, direction, Color.blue);
            
                HitObject = hit.collider.gameObject;

                if (!hit.collider.CompareTag("Player")) {
                    if (HitObject.CompareTag("VariableTransparency")){
                        if (HitObject.GetComponent<Renderer>() != null){
                            Debug.Log(previousHit);
                            if (hit.collider.gameObject != previousHit) {
                                previousHit.GetComponent<Renderer>().material = opaqueMaterial;
                                //Debug.Log("Applied Opaque");
                            } else {
                                HitObject.GetComponent<Renderer>().material = transparentMaterial;
                                //Debug.Log("Applied Transparent");
                            }
                            previousHit = HitObject;
                            Debug.Log(previousHit);
                        }
                    }
                } 
            
                if (hit.collider.tag == "Player") {
                
                    //Debug.Log("Hit Player! Call Amberlamps");
                    Debug.DrawLine(transform.position, playerPos, Color.black);
                    previousHit.GetComponent<Renderer>().material = opaqueMaterial;
                }
            
            } 
        }
        
        
    }

    
    
}
