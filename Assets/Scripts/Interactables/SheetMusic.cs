using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetMusic : InteractComponent
{
    private GameManager manager;

    void Start() {
        manager = GameState.Manager;
    }

    public override void Interact() {
        manager.DisablePlayerMovement();
        
    }
}
