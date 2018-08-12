using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
    public int DmgPerHit;


    private void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        if (hit.transform.tag == "Bullet")
            return;

        PlayerHealth health = hit.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(DmgPerHit);
        }
            Destroy(gameObject);
    }
}
