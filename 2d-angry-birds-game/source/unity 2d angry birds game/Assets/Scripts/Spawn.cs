using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    // Bird Prefab that will be spawned
    public GameObject birdPrefab;

    // Is there a Bird in the Trigger Area?
    bool occupied = false;

    void FixedUpdate() {
        // Bird not in Trigger Area anymore? And nothing is moving?
        if (!occupied && !sceneMoving())
            spawnNext();
    }

    void spawnNext() {        
        // Spawn a Bird at current position with default rotation
        Instantiate(birdPrefab, transform.position, Quaternion.identity);
        occupied = true;
    }

    void OnTriggerExit2D(Collider2D co) {
        // Bird left the Spawn
        occupied = false;
    }

    bool sceneMoving() {
        // Find all Rigidbodies, see if any is still moving a lot
        Rigidbody2D[] bodies = FindObjectsOfType(typeof(Rigidbody2D)) as Rigidbody2D[];
        foreach (Rigidbody2D rb in bodies)
            if (rb.velocity.sqrMagnitude > 5)
                return true;
        return false;
    }
}
