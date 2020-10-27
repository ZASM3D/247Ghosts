using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : InteractComponent
{
    private GameObject oldCanvas;
    private bool solved;
    public GameObject keypadCanvas;
    public GameManager manager;
    public Material unlockedMaterial;

    void Start() {
        solved = false;
    }

    public override void Interact() {
        if (solved) return;
        manager.SetActiveCanvas(keypadCanvas);
        manager.DisablePlayerMovement();
    }

    public override void TriggerPuzzle(string name) {
        Debug.Log("Safe opened");
        GetComponent<Renderer>().material = unlockedMaterial;
        solved = true;
        FinishInteract();
    }

    public void FinishInteract() {
        manager.ResetCanvas();
        manager.AllowPlayerMovement();
    }
}
