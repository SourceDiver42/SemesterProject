using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCameraBehaviour : MonoBehaviour
{
    public Transform CameraTransform;
    public float sensitivity;

    private float horizontal;
    private float vertical;
    private int invertVertical;
    private float verticalTurn;
    private Ray ray;
    private RaycastHit raycastHit;
   

    // Start is called before the first frame update
    void Start()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //raycastHit = Physics.Raycast();
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, Vector3.forward);
        if (Physics.Raycast(ray, out raycastHit, 100)){
            Debug.DrawLine(ray.origin,raycastHit.point, Color.green, 100f);
        }

        if (PlayerPrefs.GetInt("InVertical", 1) == 1){
            invertVertical = -1;
        } else {
            invertVertical = 1;
        }

        verticalTurn += Input.GetAxis("Mouse Y") * sensitivity*Time.deltaTime * invertVertical; //mouselook.cs
        verticalTurn = Mathf.Clamp(verticalTurn, -90,90);

        CameraTransform.transform.localEulerAngles = new Vector3(-verticalTurn, transform.localEulerAngles.y,transform.localEulerAngles.z);
        
        //transform.Rotate(verticalTurn, 0, 0);
        //Debug.Log(transform.rotation.y);
        
    }

    void shakingEffect() {
        //Camera.main.transform.Translate()

    }
}
