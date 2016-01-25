using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour {

    //Defines the location of the gun barrel. This is where the bullet comes out.
    public GameObject barrel;
    //Defines the bullet for prefab
    public GameObject bullet;
    //Defines a delay for bullets being shot
    float delayshot = 0.25f;
    //Defines the cool down time for the delay
    float coolDown = 0;
	
	void Update () {
        coolDown -= Time.deltaTime; 
        if (Input.GetKey(KeyCode.A) && coolDown <= 0){
            coolDown = delayshot;
            //Creates a bullet from the position of the gun barrel.
            Instantiate(bullet, barrel.transform.position, Quaternion.identity);
        }
    }
   
}
