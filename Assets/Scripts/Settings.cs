using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("GUI ELEMENTS")]

    public Slider MusicVolume;
    public Slider SFXVolume;

    public Slider FOV;

    public Slider Sensitivity;
    public Toggle invertVertical;

    public bool SoundsEnabled = true;
    public bool MusicEnabled = true;
    //public float FOV = 60f;
    private KeyCode[] Input;
    private KeyCode[] Konami;

    // Start is called before the first frame update
    void Start()
    {
        Konami = new KeyCode[]{KeyCode.UpArrow, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.DownArrow,KeyCode.LeftArrow, KeyCode.RightArrow,KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.B, KeyCode.A};
        MusicVolume.value = PlayerPrefs.GetFloat("MusicVolume", 100);
        SFXVolume.value = PlayerPrefs.GetFloat("SFXVolume", 100);
        FOV.value = PlayerPrefs.GetFloat("FOV", 90);
        Sensitivity.value = PlayerPrefs.GetFloat("Sensitivity", 50);
        invertVertical.enabled = PlayerPrefs.GetInt("Inverted", 1) == 1 ? true : false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (MusicVolume.value != PlayerPrefs.GetFloat("MusicVolume")){
            PlayerPrefs.SetFloat("MusicVolume", MusicVolume.value);
        }

        
        if (SFXVolume.value != PlayerPrefs.GetFloat("SFXVolume")){
            PlayerPrefs.SetFloat("SFXVolume", SFXVolume.value);
        }

        
        if (FOV.value != PlayerPrefs.GetFloat("FOV")){
            PlayerPrefs.SetFloat("FOV", FOV.value);
        }

        if (Sensitivity.value != PlayerPrefs.GetFloat("Sensitivity")) {
            PlayerPrefs.SetFloat("Sensitivity", Sensitivity.value);
            //Debug.Log(PlayerPrefs.GetFloat("Sensitivity"));
        }

        if (invertVertical.enabled == true){
            PlayerPrefs.SetInt("Inverted", 1);
        } else {
            PlayerPrefs.SetInt("Inverted", 0);
        }
    }
    
}
