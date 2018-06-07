using UnityEngine;
using System.Collections;

public class Trail : MonoBehaviour {

    // Trail Prefabs
    public GameObject[] trails;
    int next = 0;

    // Use this for initialization
    void Start () {    
        // Spawn a new Trail every 100 ms
        InvokeRepeating("spawnTrail", 0.1f, 0.1f);
    }

    void spawnTrail() {
        // Spawn Trail if moving fast enough
        if (GetComponent<Rigidbody2D>().velocity.sqrMagnitude > 25) {
            Instantiate(trails[next], transform.position, Quaternion.identity);
            next = (next+1) % trails.Length;
        }
    }
}
