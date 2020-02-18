using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Camera pauseCamera;
    public Camera mainCamera;
    public Image StartButton;
    public Image ContinueButton;
    public Image SettingsButton;
    public Image MiniGamesButton;
    public Image CreditsButton;
    private Object Scene;

    // Start is called before the first frame update
    void Start()
    {
       SceneManager.LoadScene("Settings", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        if (saveExists()){
            ContinueButton.enabled = true;
        }
    }

    void Play() {
        PlayerPrefs.SetInt("EXISTS", 1);
        PlayerPrefs.SetFloat("Sensitivity", 50f);
        //Sceneswitcheroo
        PlayerPrefs.Save();
        

    }

    void Continue(){
        if (!saveExists()){
            Debug.LogError("Save Doesn't Exist, Needs Proper Error Handling");
            
        }

    }

    void Credits(){

    }

    bool saveExists(){
        if (PlayerPrefs.HasKey("EXISTS")) {
            return true;

        } else { 

            return false;

        }

    }

    public void showSettings(){   
        pauseCamera.enabled = true;
        mainCamera.enabled = false;

    }
}
