using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreaking : MonoBehaviour
{
    [SerializeField] public AudioClip[] clips;
    public float minDelay = 10.0f;
    public float maxDelay = 30.0f;
    private int clipIndex;
    private AudioSource audio;

    void Start() {
        audio = gameObject.GetComponent<AudioSource>();
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound() {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));

        clipIndex =  Random.Range(0, clips.Length);
        audio.PlayOneShot(clips[clipIndex], 1f);
        Debug.Log(clips[clipIndex]);

        yield return new WaitForSeconds(clips[clipIndex].length);
        StartCoroutine(PlaySound());
    }
}
