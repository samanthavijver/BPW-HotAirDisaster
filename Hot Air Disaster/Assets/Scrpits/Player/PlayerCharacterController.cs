using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {

    public float speed = 10.0f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Set Cursor to not be visible
        Cursor.visible = false;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
        Cursor.lockState = CursorLockMode.None;
        }

    }

    void Fire()
    {
        if (Time.deltaTime == 0)
        {
            return;
        }
            
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }

}
