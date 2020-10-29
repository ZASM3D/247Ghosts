using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : InteractComponent
{
    public GameManager manager;
    public string noteText;

    public override void Interact() {
        manager.DisablePlayerMovement();
        manager.LoadNote(noteText);
    }
}
