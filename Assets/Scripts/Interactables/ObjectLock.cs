using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : InteractComponent
{
    public string requiredObject;

    public override void Interact() {
        if (GameState.Manager.CheckPlayerHasItem(requiredObject)) {
            // ...do the thing
            GameState.Manager.RemoveItem(requiredObject);
            Debug.Log("Unlocked with " + requiredObject);
            this.gameObject.SetActive(false);
        }
    }
}
