using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : InteractComponent
{
    private GameManager manager;
    public string noteText;

    void Start() {
        GameObject man = GameObject.Find("Game Manager");
        if (!man) {
            Debug.LogError("Add a Game Manger to the scene (It's in prefabs)");
            Debug.Break();
        }
        manager = man.GetComponent<GameManager>();
    }

    public override void Interact() {
        manager.DisablePlayerMovement();
        manager.LoadNote(noteText);
    }
}
