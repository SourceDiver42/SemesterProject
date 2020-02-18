using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter : MonoBehaviour
{

    public ParticleSystem TeleportStart;
    public Object SceneObject;
    private float FOV;
    private string Scene;

    // Start is called before the first frame update
    void Start()
    {
        FOV = Camera.main.fieldOfView;
        Scene = SceneObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        TeleportStart.Play();

        while (FOV < 150f){
            Camera.main.fieldOfView +=5; //Stretch the FOV
            
            SceneManager.LoadScene(Scene);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TeleportStart.Stop();
        FOV = PlayerPrefs.GetFloat("FOV");
        
    }
}
