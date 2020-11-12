using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FicklePiano : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        source.Pause();
    }

    void OnTriggerExit(Collider other) {
        source.PlayDelayed(Random.Range(0.0f, 70.0f));
    }
}
