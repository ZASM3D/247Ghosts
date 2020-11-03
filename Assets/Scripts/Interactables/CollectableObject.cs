using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : InteractComponent
{
    public string item;

    public override void Interact() {
        GameState.Manager.GivePlayerItem(item);
        this.gameObject.SetActive(false);
    }
}
