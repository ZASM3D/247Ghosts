using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : InteractComponent
{
    private GameManager manager;
    public string noteText;

    void Start() {
        manager = GameState.Manager;
    }

    public override void Interact() {
        manager.DisablePlayerMovement();
        manager.LoadNote(noteText);
    }
}
