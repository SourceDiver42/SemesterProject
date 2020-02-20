using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public GameObject[] Collectibles;
    
    public int collectedItems;
    public Text collectedItems_Text;
    private string testString;
    private ArrayList collectedArr = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in Collectibles){
            if(obj.activeSelf == false){
                Debug.Log(obj + "disabled");
                if (!collectedArr.Contains(obj)){
                    collectedArr.Add(obj);
                }
            }
        }
        
        collectedItems_Text.text = collectedArr.Count.ToString();
        //Debug.Log(collectedItems_Text.text);

    }
}
