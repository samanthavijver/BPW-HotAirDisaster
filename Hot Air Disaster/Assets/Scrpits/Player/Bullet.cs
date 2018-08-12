using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public int DmgPerHit;

    private void Awake()
    {
        Physics.IgnoreLayerCollision(8, 10, true);
    }


    private void OnTriggerEnter(Collider other)
    {
        var hit = other.gameObject;
        var health = hit.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(DmgPerHit);
        }

        Destroy(gameObject);
    }


}
