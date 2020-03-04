using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    private AudioSource audioSource;
    private float remainingDistance;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Transform getClosestObject(Transform[] objects) { //https://forum.unity.com/threads/clean-est-way-to-find-nearest-object-of-many-c.44315/
        Transform closestObject = null;
        float minDistance = Mathf.Infinity;
        Vector3 currentPos = transform.position;

        foreach (Transform t in objects) {
            float dist = Vector3.Distance(t.position, currentPos);
            if (dist < minDistance) {
                closestObject = t;
                minDistance = dist;
            }    
        }
        return closestObject;
    }
}
