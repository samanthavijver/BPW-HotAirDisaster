using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public GameObject enemybulletPrefab;    //The bullet be spawned
    public Transform bulletSpawn;           //
    public Transform bulletSpawn2;
    public float spawnTime = 3f;            // How long between each spawn.
    private GameObject bullet;              //

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Shoot", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update ()
    {

    }

    void Shoot()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            enemybulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        var bullet2 = (GameObject)Instantiate(
           enemybulletPrefab,
           bulletSpawn2.position,
           bulletSpawn2.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
        bullet2.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
        Destroy(bullet2, 2.0f);
    }

}
