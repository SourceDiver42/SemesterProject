using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    [Header("Actions")]
    public GameObject Open;
    public GameObject Close;
    public GameObject FlipFlop;
    
    [Header("Properties")]
    public bool Invert = false;
    public bool Broken = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
