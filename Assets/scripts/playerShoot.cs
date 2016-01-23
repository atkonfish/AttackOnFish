using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour {

    //Define the bullet for prefab
    public GameObject bullet;
    //Define a delay for bullets being shot
    float delayshot = 0.25f;
    //Define the cool down time for the delay
    float coolDown = 0;
	
	void Update () {
        coolDown -= Time.deltaTime; 
        if (Input.GetKey(KeyCode.A) && coolDown <= 0){
            coolDown = delayshot;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
   
}
