using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : InteractComponent
{
    public string[] requiredObjects;
    public bool removeObjects = true;

    public override void Interact() {
        foreach (string obj in requiredObjects) {
            if (!GameState.Manager.CheckPlayerHasItem(obj)) {
                return;
            }

            if (removeObjects)
                GameState.Manager.RemoveItem(obj);
        }
        UnlockAction();
    }

    public virtual void UnlockAction() {
        this.gameObject.SetActive(false);
    }
}
