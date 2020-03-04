using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    public float timeuntilDestroy = 5f;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        timeuntilDestroy = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        timeuntilDestroy -= Time.deltaTime;
        Text.text = timeuntilDestroy.ToString();
        if (timeuntilDestroy < 0) {
            Text.text = "0";
            this.gameObject.SetActive(false);
        }
    }

    

}
