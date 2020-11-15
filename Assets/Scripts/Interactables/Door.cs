using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : ObjectLock
{
    private bool open = false;
    public Transform openLocation;

    void Start() {
        removeObjects = false;
    }

    public override void UnlockAction() {
        if (open) return;
        open = true;
        this.transform.position = openLocation.position;
        this.transform.rotation = openLocation.rotation;
    }
}
