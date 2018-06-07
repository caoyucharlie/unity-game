using UnityEngine;
using System.Collections;

public class BreakOnImpact : MonoBehaviour {
    public float forceNeeded = 1000;

    float collisionForce(Collision2D coll) {
        // Estimate a collision's force (speed * mass)
        float speed = coll.relativeVelocity.sqrMagnitude;
        if (coll.collider.GetComponent<Rigidbody2D>())
            return speed * coll.collider.GetComponent<Rigidbody2D>().mass;
        return speed;
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (collisionForce(coll) >= forceNeeded)
            Destroy(gameObject);
    }
}
