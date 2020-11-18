using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableWithDialogue : InteractComponent
{
    public string item;
    public GameObject dialogue;

    public override void Interact() {
        GameState.Manager.GivePlayerItem(item);
        this.gameObject.SetActive(false);
        dialogue.SetActive(true);
    }
}
