using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : InteractComponent
{
    public string[] requiredObjects;
    public bool removeObjects = true;

    public override void Interact() {
        Debug.Log("Interacted with");
        foreach (string obj in requiredObjects) {
            if (!GameState.Manager.CheckPlayerHasItem(obj)) {
                Debug.Log("Don't have required object");
                Debug.Log(obj);
                return;
            }

            Debug.Log("Do have required object");
            Debug.Log(obj);
            if (removeObjects)
                GameState.Manager.RemoveItem(obj);
        }
        UnlockAction();
    }

    public virtual void UnlockAction() {
        Debug.Log("reached interact action in object lock script");
        this.gameObject.SetActive(false);
    }
}
