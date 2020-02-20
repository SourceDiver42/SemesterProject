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

    private bool readyState;
    

    // Start is called before the first frame update
    void Start()
    {
        FlareText.text = "Ready";
        RadioText.text = "Ready";
        readyState = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (readyState == false) {
            if (FlareDelay > 0f) {
                FlareDelay -= Time.deltaTime;
                FlareText.text = FlareDelay.ToString();
                if (FlareDelay < 0) {
                    readyState = true;
                }
            }
        }
        if (readyState) {
            FlareText.text = "Ready";
        }
    }
}
