using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviour : MonoBehaviour
{
    public GameObject Gun;
    public GameObject bulletPrefab;
    public float speed = 120f;
    public float LifeTime = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Gun.activeSelf == true){
            if (Input.GetButtonDown("Attack")){
                GameObject bullet = Instantiate(bulletPrefab, Gun.transform.position, Gun.transform.rotation);
                Rigidbody bulletrb = bullet.GetComponent<Rigidbody>();
                //bullet.transform.position = transform.forward * speed * Time.deltaTime;
                bulletrb.AddRelativeForce(new Vector3(0,0,speed));
                Destroy(bullet, LifeTime);

            }
        }
    }
}
