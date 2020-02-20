

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovementBehaviour : MonoBehaviour
{
    #region Definitions

    private float horizontal;
    private float vertical;
    private float playerRotation;
    private bool jump;
    
    public float sensitivity;

    private const string AXIS_SPRINT = "Sprint";
    
    public float acceleration = 0.25f;
    public bool GameMode_Fighting = false;
    public CharacterController characterController;
    private float horizontalTurn;

    #endregion



    void Start()
    {
        sensitivity = PlayerPrefs.GetFloat("Sensitivity");
        
    }

    
    void Update()
    {

        sensitivity = PlayerPrefs.GetFloat("Sensitivity"); //In case the Player changed it in the Settings
        acceleration = 0.25f;
        horizontalTurn = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        jump = Input.GetAxis("Jump") > 0;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if(Input.GetAxis(AXIS_SPRINT) > 0){

            acceleration += 1.5f;

        }

        Vector3 destination = new Vector3(horizontal, 0f, vertical) * acceleration;
        
        //Debug.Log(destination);
        
        transform.Translate(destination, Space.Self);
        transform.Rotate(0, horizontalTurn, 0, Space.World);

    }


    

    
}
