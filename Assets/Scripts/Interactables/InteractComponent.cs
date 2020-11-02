using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractComponent : TriggerableObject
{    
    public virtual void Interact() {
        Debug.Log(this + " was interacted with.");
    }
}
