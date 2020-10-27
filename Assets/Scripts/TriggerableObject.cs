using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerableObject : MonoBehaviour
{
    public virtual void TriggerPuzzle(string name) {
        Debug.Log(name + " solved!");
    }
}
