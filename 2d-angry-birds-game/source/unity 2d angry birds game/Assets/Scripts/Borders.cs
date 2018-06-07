using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co) {
        Destroy(co.gameObject);
    }
}
