using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCameraBehaviour : MonoBehaviour
{
    //private GameObject HitObject;
    //private Color HitObjectRendererColor;
    private float transparency = 1.0f;
    public Material transparentMaterial;
    public Material opaqueMaterial;
    GameObject previousHit;
    // Start is called before the first frame update
    void Start()
    {
        previousHit = GameObject.Find("Radio");
    }

    
    

    void FixedUpdate()
    {
        Vector3 playerPos = GameObject.FindWithTag("Player").transform.position;
        Vector3 direction = ( playerPos - transform.position );
        Ray ray = new Ray(transform.position, direction);
        RaycastHit hit;
        GameObject HitObject;
        
        
        

        if (Physics.Raycast(ray, out hit)){
            Debug.DrawRay (transform.position, direction, Color.blue);
            
            HitObject = GameObject.Find(hit.collider.name);

            if (hit.collider.tag != "Player") {

                if (HitObject.GetComponent<Renderer>() != null){
                    Debug.Log(previousHit);
                    if (hit.collider.gameObject != HitObject) {
                        previousHit.GetComponent<Renderer>().material = opaqueMaterial;
                        Debug.Log("Applied Opaque");
                    } else {
                        HitObject.GetComponent<Renderer>().material = transparentMaterial;
                        Debug.Log("Applied Transparent");
                    }
                    previousHit.name = hit.collider.name;
                    Debug.Log(previousHit);
                }
            
            } 
            
            if (hit.collider.tag == "Player") {
                
                //Debug.Log("Hit Player! Call Amberlamps");
                Debug.DrawLine(transform.position, playerPos, Color.black);
                previousHit.GetComponent<Renderer>().material = opaqueMaterial;
            }
            
        } 

        
        
    }

    /*
    *
    *   Inspired by http://answers.unity.com/answers/225880/view.html
    *
    */
    void FadeToOpaque(Renderer transparent){
        Color transp = transparent.material.color;
        for (float t = 0.0f; t<1.0f; t += Time.deltaTime/0.8f) {
            Color newTransparency = new Color(1,1,1,Mathf.Lerp(transp.a,1.0f,t));
            transp = newTransparency;
        }
    }
}
