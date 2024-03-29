﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //private bool isMenuCameraActive = false;
    public Camera MainCamera;
    private Camera MenuCamera;
    //public Camera MenuCamera;
    public float FOV;
    public bool DEBUG;

    void Start()
    {
        FOV = Camera.main.fieldOfView;
        //SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        MenuCamera = GameObject.Find("MenuCamera").GetComponent<Camera>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        MainCamera.enabled = true;
        //MenuCamera.enabled = false;
        setDebugPlayerPrefs();
    }

    void Update()
    {
        //pauseChecker();
    }

    void pauseChecker() {
        Debug.Log(Time.timeScale);
        Debug.Log(SceneManager.GetActiveScene().name);
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (Time.timeScale == 1) {
                Time.timeScale = 0;
                Time.fixedDeltaTime = 0;
                MainCamera.enabled = false;
                
                SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));
                MenuCamera.enabled = true;
                Cursor.lockState = CursorLockMode.Confined;
                

            } else if (Time.timeScale == 0) {
                Time.timeScale = 1;
                Time.fixedDeltaTime = 1;
                MainCamera.enabled = true;
                MenuCamera.enabled = false;
                
            }
        }
    }
   void setDebugPlayerPrefs(){
       PlayerPrefs.SetInt("InVertical", 0);
       PlayerPrefs.SetFloat("Sensitivity", 150f);
       PlayerPrefs.SetInt("EXISTS", 1);
       PlayerPrefs.SetFloat("HighScore",10000);
   }
    
}
