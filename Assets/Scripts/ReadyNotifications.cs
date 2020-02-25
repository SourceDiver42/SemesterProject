using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyNotifications : MonoBehaviour
{

    public Text FlareText;
    public Text RadioText;

    private float FlareDelay = 20f;
    private float RadioDelay = 30f;

    private bool flareReadyState = true;
    private bool radioReadyState = true;
    

    // Start is called before the first frame update
    void Start()
    {
        FlareText.text = "Ready";
        RadioText.text = "Ready";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flareReadyState == false) {
            if (FlareDelay > 0f) {
                FlareDelay -= Time.deltaTime;
                FlareText.text = FlareDelay.ToString();
                if (FlareDelay < 0) {
                    flareReadyState = true;
                }
            }
        }
        if (flareReadyState) {
            FlareText.text = "Ready";
        }

        if (radioReadyState == false) {
            if (RadioDelay > 0f) {
                RadioDelay -= Time.deltaTime;
                RadioText.text = RadioDelay.ToString();
                if (RadioDelay < 0) {
                    radioReadyState = true;
                }
            }
        }
        if (radioReadyState) {
            RadioText.text = "Ready";
        }
    }
}
