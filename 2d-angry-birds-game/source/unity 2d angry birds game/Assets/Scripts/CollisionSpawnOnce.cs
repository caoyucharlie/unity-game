using UnityEngine;
using System.Collections;

public class CollisionSpawnOnce : MonoBehaviour {
    // Whatever should be spawned (Particles etc.)
    public GameObject effect;

    void OnCollisionEnter2D(Collision2D coll) {
        // Spawn Effect, then remove Script
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(this);
    }
}
