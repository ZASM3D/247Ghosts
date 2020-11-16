using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCase : MonoBehaviour
{
    public int unlocksNeeded;
    private int numUnlocks = 0;
    private bool open = false;
    public Transform openLocation;

    public void IncrementCount() {
        numUnlocks++;
        if (numUnlocks < unlocksNeeded || open)
            return;

        open = true;
        this.transform.position = openLocation.position;
        this.transform.rotation = openLocation.rotation;
    }
}
