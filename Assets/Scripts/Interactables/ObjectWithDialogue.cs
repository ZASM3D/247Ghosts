using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithDialogue : InteractComponent
{
    public GameObject dialogue;

    public override void Interact() {
        dialogue.SetActive(true);
    }
}
