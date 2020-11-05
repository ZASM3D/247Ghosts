using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : ObjectLock
{
    private bool open = false;
    public Transform openLocation;

    public override void Interact() {
        Debug.Log("Interact with: " + this.gameObject);
        if (open) return;
        if (string.Compare(requiredObject, "") == 0|| GameState.Manager.CheckPlayerHasItem(requiredObject)) {
            Debug.Log("Opened");
            open = true;
            this.transform.position = openLocation.position;
            this.transform.rotation = openLocation.rotation;
            //GameState.Manager.RemoveItem(requiredObject);
        }
    }
}
