using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flare : MonoBehaviour
{
    public float timeuntilDestroy = 5f;
    private Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("FlareReady").GetComponent<Text>();
        timeuntilDestroy = 5f; //remove to use public variable
    }

    // Update is called once per frame
    void Update()
    {
        timeuntilDestroy -= Time.deltaTime;
        
        Text.text = timeuntilDestroy.ToString().Substring(0, 3);
        if (timeuntilDestroy < 0) {
            Text.text = "0";
            Text.text = "Ready";
            this.gameObject.SetActive(false);
        }
    }
}
